/*
    This file is part of the Unifi (R) project.
    Copyright (c) 2020 Irene Solutions SL
    Authors: Irene Solutions SL.

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License version 3
    as published by the Free Software Foundation with the addition of the
    following permission added to Section 15 as permitted in Section 7(a):
    FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
    IRENE SOLUTIONS SL. IRENE SOLUTIONS SL DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
    OF THIRD PARTY RIGHTS
    
    This program is distributed in the hope that it will be useful, but
    WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
    or FITNESS FOR A PARTICULAR PURPOSE.
    See the GNU Affero General Public License for more details.
    You should have received a copy of the GNU Affero General Public License
    along with this program; if not, see http://www.gnu.org/licenses or write to
    the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
    Boston, MA, 02110-1301 USA, or download the license from the following URL:
        http://www.irenesolutions.com/terms-of-use.pdf
    
    The interactive user interfaces in modified source and object code versions
    of this program must display Appropriate Legal Notices, as required under
    Section 5 of the GNU Affero General Public License.
    
    You can be released from the requirements of the license by purchasing
    a commercial license. Buying such a license is mandatory as soon as you
    develop commercial activities involving the Unifi software without
    disclosing the source code of your own applications.
    These activities include: offering paid services to customers as an ASP,
    serving Unifi services on the fly in a web application, shipping Unifi
    with a closed source product.
    
    For more information, please contact Irene Solutions SL. at this
    address: info@irenesolutions.com
 */

using System;
using System.Collections.Generic;
using Unifi.Xml;
using Unifi.Xml.Pain.Common;
using Unifi.Xml.Pain.CustomerCreditTransferInitiation;

namespace Unifi.Business.Pain
{

    /// <summary>
    /// Representa un Direct Debit.
    /// </summary>
    public class CustomerCreditTransferInitiation
    {

        /// <summary>
        /// Diccionario con los serializadores por versión.
        /// </summary>
        Dictionary<CustomerCreditTransferInitiationVersions, Func<byte[]>> _Parsers =
             new Dictionary<CustomerCreditTransferInitiationVersions, Func<byte[]>>();
       

        /// <summary>
        /// Devuelve los datos binarios del xml conformado en arreglo a las
        /// especificaciones de la versión 3.
        /// </summary>
        /// <returns></returns>
        private byte[] GetXmlV03() 
        {
            // PREPARAMOS LA CABECERA Y DIMENSIONAMOS REGISTROS

            var document = new Xml.Pain.CustomerCreditTransferInitiationV03.Document();

            var debtor = new PartyIdentification()
            {
                Nm = Debtor.Name,
                Id = new PartyChoice()
                {
                    Item = new OrganisationIdentification()
                    {
                        Othr = new GenericOrganisationIdentification[1]
                            {
                                new GenericOrganisationIdentification()
                                {
                                    Id = Debtor.Identification
                                }
                            }
                    }
                }
            };

            document.CstmrCdtTrfInitn.GrpHdr = new GroupHeader()
            {
                MsgId = MessageIdentification,                  // Id. mensaje
                CreDtTm = CreationDateTime,                     // Creación
                CtrlSum = ControlSum,                           // Importe total
                CtrlSumSpecified = true,
                NbOfTxs = $"{NumberOfTransactions}",            // Número de transacciones
                InitgPty = debtor
            };

            document.CstmrCdtTrfInitn.PmtInf = new PaymentInstruction[1]
            {
                new PaymentInstruction()
                {
                    PmtInfId = PaymentInformationIdentification,
                    PmtMtd = PaymentMethodCode.TRF,
                    BtchBookg = true,
                    BtchBookgSpecified = true,
                    NbOfTxs = $"{NumberOfTransactions}",
                    CtrlSum = ControlSum,
                    CtrlSumSpecified = true,
                    PmtTpInf = new PaymentTypeInformation()
                    {
                        SvcLvl = new CdOrPrtryTypeChoice()
                        {
                            Item = ServiceLevel
                        }
                    },
                    ReqdExctnDt = RequestedExecutionDate,
                    Dbtr = debtor,
                    DbtrAcct = new CashAccount()
                    {
                        Id = new AccountIdentificationChoice()
                        {
                            Item = Debtor.IBAN,
                            ItemElementName = AccountIdentificationType.IBAN
                        }
                    },
                    DbtrAgt = new BranchAndFinancialInstitutionIdentification()
                    {
                        FinInstnId = new FinancialInstitutionIdentification()
                        {
                            BIC = Debtor.BIC
                        }
                    },                   
                    CdtTrfTxInf = new CreditTransferTransactionInformation[NumberOfTransactions]
                }
            };

            int index = 0;

            foreach (var creditTransferTransaction in CreditTransferTransactions)
            {

                if (index > 999)
                    throw new Exception("Max CreditTransferTransactions number (1000) exceded.");

                creditTransferTransaction.PaymentIdentification = $"{MessageIdentification}-" +$"{index + 1}".PadLeft(3, '0');

                document.CstmrCdtTrfInitn.PmtInf[0].CdtTrfTxInf[index++] = new CreditTransferTransactionInformation()
                {
                    PmtId = new PaymentIdentification()
                    {
                        EndToEndId = creditTransferTransaction.PaymentIdentification,
                        InstrId = creditTransferTransaction.PaymentIdentification
                    },
                    Amt = new PaymentTransactionInformation() 
                    {
                        InstdAmt = new ActiveOrHistoricCurrencyAndAmount()
                        {
                            Ccy = creditTransferTransaction.Currency,
                            Value = creditTransferTransaction.Amount
                        }
                    },
                    CdtrAgt = new BranchAndFinancialInstitutionIdentification()
                    {
                        FinInstnId = new FinancialInstitutionIdentification()
                        {
                            BIC = creditTransferTransaction.Creditor.BIC
                        }
                    },
                    Cdtr = new PartyIdentification()
                    {
                        Nm = creditTransferTransaction.Creditor.Name
                    },
                    CdtrAcct = new CashAccount()
                    {
                        Id = new AccountIdentificationChoice()
                        {
                            Item = creditTransferTransaction.Creditor.IBAN,
                            ItemElementName = AccountIdentificationType.IBAN
                        }
                    },
                    RmtInf = new RemittanceInformation()
                    {
                        Ustrd = creditTransferTransaction.RemittanceInformation
                    }
                };
            }

            return XmlParser<Xml.Pain.CustomerCreditTransferInitiationV03.Document>.ToXml(document);

        }

        /// <summary>
        /// Identificación de mensaje
        /// </summary>
        public string MessageIdentification { get; set; }

        /// <summary>
        /// Identificación única, según lo asignado por una parte que envía,
        /// para identificar inequívocamente el grupo de información de pago
        /// dentro del mensaje.
        /// </summary>
        public string PaymentInformationIdentification
        {
            get
            {
                return $"{MessageIdentification}-001";
            }
        }

        /// <summary>
        /// Fecha y hora de creación
        /// </summary>
        public DateTime CreationDateTime { get; set; }

        /// <summary>
        /// Número de operaciones
        /// </summary>
        public int NumberOfTransactions 
        { 
            get 
            { 
                return CreditTransferTransactions == null ? 0 : CreditTransferTransactions.Count; 
            } 
        }

        /// <summary>
        /// Suma de control correspondiente a la suma de
        /// cada una de las operaciones de pago, independientemente
        /// de la moneda de denominación de las mimas.
        /// </summary>
        public decimal ControlSum
        {
            get
            {

                decimal sum = 0;

                if (CreditTransferTransactions == null)
                    return sum;

                foreach (var creditTransferTransaction in CreditTransferTransactions)
                    sum += creditTransferTransaction.Amount;

                return sum;


            }
        }


        /// <summary>
        /// Acuerdo bajo el cual o reglas bajo las cuales la transacción debe ser procesada.
        /// </summary>
        public string ServiceLevel { get; set; }

        /// <summary>
        /// Instrumento específico de la comunidad de usuarios.
        /// Uso: Este elemento se usa para especificar un instrumento
        /// local, una opción de compensación local y / o calificar aún
        /// más el servicio o nivel de servicio.
        /// </summary>
        public string LocalInstrument { get; set; }

        /// <summary>
        /// Especifica el propósito de alto nivel de la instrucción en función de un conjunto de categorías predefinidas. 
        /// Uso: La parte iniciadora lo utiliza para proporcionar información sobre el procesamiento del pago.
        /// Es probable que desencadene un procesamiento especial por parte de cualquiera de los agentes involucrados
        /// en la cadena de pago.
        /// </summary>
        public string CategoryPurpose { get; set; }

        /// <summary>
        /// Fecha y hora en que el acreedor solicita que la cantidad de dinero se recaude del deudor.
        /// Fecha en que la parte iniciadora solicita al agente de compensación que procese el pago.
        /// Uso: Esta es la fecha en que se debitará la cuenta del deudor. Si pago con cheque, la
        /// fecha en que el banco debe generar el cheque.
        /// </summary>
        public DateTime RequestedExecutionDate { get; set; }

        /// <summary>
        /// Deudor emisor del transferencias.
        /// </summary>
        public CustomerCreditTransferInitiationParty Debtor { get; set; }

        /// <summary>
        /// Proporciona más detalles específicos de las transacciones de débito directo individuales incluidas en el mensaje.
        /// </summary>
        public List<CustomerCreditTransferInitiationPayment> CreditTransferTransactions { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public CustomerCreditTransferInitiation() 
        {

            ServiceLevel = "SEPA";
            LocalInstrument = "COR1";
            CategoryPurpose = "CASH";

            _Parsers[CustomerCreditTransferInitiationVersions.V03] = GetXmlV03;           

        }

        /// <summary>
        /// Devuelve el archivo xml correspondiente.
        /// </summary>
        /// <param name="version">Versión a utilizar.</param>
        /// <returns>Archivo xml correspondiente</returns>
        public byte[] GetXml(CustomerCreditTransferInitiationVersions version = CustomerCreditTransferInitiationVersions.V03) 
        {

            if (!_Parsers.ContainsKey(version))
                throw new NotImplementedException($"Version {version} not implemented.");

            return _Parsers[version]();

        }

    }
}
