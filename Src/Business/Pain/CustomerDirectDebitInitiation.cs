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
using Unifi.Xml.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Business.Pain
{

    /// <summary>
    /// Representa un Direct Debit.
    /// </summary>
    public class CustomerDirectDebitInitiation
    {
        /// <summary>
        /// Diccionario con los serializadores por versión.
        /// </summary>
        Dictionary<CustomerDirectDebitInitiationVersions, Func<byte[]>> _Parsers = new Dictionary<CustomerDirectDebitInitiationVersions, Func<byte[]>>();       

        /// <summary>
        /// Devuelve los datos binarios del xml conformado en arreglo a las
        /// especificaciones de la versión 2.
        /// </summary>
        /// <returns></returns>
        private byte[] GetXmlV02() 
        {
            // PREPARAMOS LA CABECERA Y DIMENSIONAMOS REGISTROS

            var document = new Xml.Pain.CustomerDirectDebitInitiationV02.Document();

            document.CstmrDrctDbtInitn.GrpHdr = new GroupHeader()
            {
                MsgId = MessageIdentification,                  // Id. mensaje
                CreDtTm = CreationDateTime,                     // Creación
                CtrlSum = ControlSum,                           // Importe total
                CtrlSumSpecified = true,
                NbOfTxs = $"{NumberOfTransactions}",            // Número de transacciones
                InitgPty = new PartyIdentification()
                {
                    Nm = Creditor.Name,
                    Id = new PartyChoice()
                    {
                        Item = new OrganisationIdentification()
                        {
                            Othr = new GenericOrganisationIdentification[1]
                            {
                                new GenericOrganisationIdentification()
                                {
                                    Id = Creditor.Identification
                                }
                            }
                        }
                    }
                }
            };

            if (DirectDebitTransactions.Count > 999)
                throw new Exception("Max DirectDebitTransactions number (1000) exceded.");

            // Agrupamos las transacciones por fecha de cargo/abono.
            Dictionary<DateTime, List<CustomerDirectDebitInitiationPayment>> paymentsByRequestedExecutionDate = new Dictionary<DateTime, List<CustomerDirectDebitInitiationPayment>>();

            foreach (CustomerDirectDebitInitiationPayment directDebitTransaction in DirectDebitTransactions)
            {
                if (!paymentsByRequestedExecutionDate.ContainsKey(directDebitTransaction.RequestedExecutionDate))
                    paymentsByRequestedExecutionDate.Add(directDebitTransaction.RequestedExecutionDate, new List<CustomerDirectDebitInitiationPayment>());

                paymentsByRequestedExecutionDate[directDebitTransaction.RequestedExecutionDate].Add(directDebitTransaction);
            }

            int index = -1;
            int transactionIndex = -1;

            document.CstmrDrctDbtInitn.PmtInf = new PaymentInstruction[paymentsByRequestedExecutionDate.Count];

            foreach (var item in paymentsByRequestedExecutionDate)
            {
                DateTime transactionsDate = item.Key;
                List<CustomerDirectDebitInitiationPayment> transactionsList = item.Value;
                decimal transactionsSum = 0;
                foreach (var payment in transactionsList) transactionsSum += payment.Amount;

                // Añadimos la cabecera de cada bloque PaymentInfo (el cual depende de la fecha a la que se realice el cargo/abono).

                document.CstmrDrctDbtInitn.PmtInf[++index] = new PaymentInstruction()
                {
                    PmtInfId = PaymentInformationIdentification,
                    PmtMtd = PaymentMethodCode.DD,
                    BtchBookg = true,
                    NbOfTxs = $"{transactionsList.Count}",
                    CtrlSum = transactionsSum,
                    PmtTpInf = new PaymentTypeInformation()
                    {
                        SvcLvl = new CdOrPrtryTypeChoice()
                        {
                            Item = ServiceLevel
                        },
                        LclInstrm = new CdOrPrtryTypeChoice()
                        {
                            Item = LocalInstrument
                        },
                        SeqTp = SequenceTypeCode.RCUR,
                        SeqTpSpecified = true,
                        CtgyPurp = new CdOrPrtryTypeChoice()
                        {
                            Item = CategoryPurpose
                        },
                        CtgyPurpSpecified = true
                    },
                    ReqdColltnDt = transactionsDate, // Fecha de abono
                    Cdtr = new PartyIdentification()
                    {
                        Nm = Creditor.Name
                    },
                    CdtrAcct = new CashAccount()
                    {
                        Id = new AccountIdentificationChoice()
                        {
                            Item = Creditor.IBAN,
                            ItemElementName = AccountIdentificationType.IBAN
                        }
                    },
                    CdtrAgt = new BranchAndFinancialInstitutionIdentification()
                    {
                        FinInstnId = new FinancialInstitutionIdentification()
                        {
                            BIC = Creditor.BIC
                        }
                    },
                    CdtrSchmeId = new PartyIdentification()
                    {
                        Id = new PartyChoice()
                        {
                            Item = new PersonIdentification()
                            {
                                Othr = new GenericIdentificationCdOrPrtry[1]
                                    {
                                        new GenericIdentificationCdOrPrtry()
                                        {
                                            Id = Creditor.Identification,
                                            SchmeNm = new CdOrPrtryTypeChoice()
                                            {
                                                Item = Creditor.SchmeNm,
                                                ItemElementName = CdOrPrtryType.Prtry
                                            }
                                        }
                                    }
                            }
                        }
                    },
                    DrctDbtTxInf = new DirectDebitTransactionInformation[transactionsList.Count]
                };

                // Añadimos las líneas al bloque de PaymentInfo.

                foreach (var directDebitTransaction in transactionsList)
                {
                    directDebitTransaction.PaymentIdentification = $"{MessageIdentification}-" + $"{++transactionIndex + 1}".PadLeft(3, '0');

                    document.CstmrDrctDbtInitn.PmtInf[index].DrctDbtTxInf[transactionIndex] = new DirectDebitTransactionInformation()
                    {
                        PmtId = new PaymentIdentification()
                        {
                            EndToEndId = directDebitTransaction.PaymentIdentification,
                            InstrId = directDebitTransaction.PaymentIdentification
                        },
                        InstdAmt = new ActiveOrHistoricCurrencyAndAmount()
                        {
                            Ccy = directDebitTransaction.Currency,
                            Value = directDebitTransaction.Amount
                        },
                        DrctDbtTx = new PaymentTransaction()
                        {
                            MndtRltdInf = new MandateRelatedInformation()
                            {
                                MndtId = directDebitTransaction.MandateIdentification,
                                DtOfSgntr = directDebitTransaction.DateOfSignature,     // Fecha de firma
                                DtOfSgntrSpecified = true,
                                AmdmntInd = false,
                                AmdmntIndSpecified = true
                            }
                        },
                        DbtrAgt = new BranchAndFinancialInstitutionIdentification()
                        {
                            FinInstnId = new FinancialInstitutionIdentification()
                            {
                                BIC = directDebitTransaction.Debtor.BIC
                            }
                        },
                        Dbtr = new PartyIdentification()
                        {
                            Nm = directDebitTransaction.Debtor.Name
                        },
                        DbtrAcct = new CashAccount()
                        {
                            Id = new AccountIdentificationChoice()
                            {
                                Item = directDebitTransaction.Debtor.IBAN,
                                ItemElementName = AccountIdentificationType.IBAN
                            }
                        },
                        Purp = new CdOrPrtryTypeChoice()
                        {
                            Item = directDebitTransaction.Purpose
                        },
                        RmtInf = new RemittanceInformation()
                        {
                            Ustrd = directDebitTransaction.RemittanceInformation
                        }
                    };
                }

                transactionIndex = -1;
            }

            return XmlParser<Xml.Pain.CustomerDirectDebitInitiationV02.Document>.ToXml(document);
        }

        /// <summary>
        /// Devuelve los datos binarios del xml conformado en arreglo a las
        /// especificaciones de la versión 2.
        /// </summary>
        /// <returns></returns>
        private byte[] GetXmlV08()
        {
            // PREPARAMOS LA CABECERA Y DIMENSIONAMOS REGISTROS

            var document = new Xml.Pain.CustomerDirectDebitInitiationV08.Document();

            document.CstmrDrctDbtInitn.GrpHdr = new GroupHeader()
            {
                MsgId = MessageIdentification,                  // Id. mensaje
                CreDtTm = CreationDateTime,                     // Creación
                CtrlSum = ControlSum,                           // Importe total
                CtrlSumSpecified = true,
                NbOfTxs = $"{NumberOfTransactions}",            // Número de transacciones
                InitgPty = new PartyIdentification()
                {
                    Nm = Creditor.Name,
                    Id = new PartyChoice()
                    {
                        Item = new OrganisationIdentification()
                        {
                            Othr = new GenericOrganisationIdentification[1]
                            {
                                new GenericOrganisationIdentification()
                                {
                                    Id = Creditor.Identification
                                }
                            }
                        }
                    }
                }
            };

            if (DirectDebitTransactions.Count > 999)
                throw new Exception("Max DirectDebitTransactions number (1000) exceded.");

            // Agrupamos las transacciones por fecha de cargo/abono.
            Dictionary<DateTime, List<CustomerDirectDebitInitiationPayment>> paymentsByRequestedExecutionDate = new Dictionary<DateTime, List<CustomerDirectDebitInitiationPayment>>();

            foreach (CustomerDirectDebitInitiationPayment directDebitTransaction in DirectDebitTransactions)
            {
                if (!paymentsByRequestedExecutionDate.ContainsKey(directDebitTransaction.RequestedExecutionDate))
                    paymentsByRequestedExecutionDate.Add(directDebitTransaction.RequestedExecutionDate, new List<CustomerDirectDebitInitiationPayment>());

                paymentsByRequestedExecutionDate[directDebitTransaction.RequestedExecutionDate].Add(directDebitTransaction);
            }

            int index = -1;
            int transactionIndex = -1;

            document.CstmrDrctDbtInitn.PmtInf = new PaymentInstruction[paymentsByRequestedExecutionDate.Count];

            foreach (var item in paymentsByRequestedExecutionDate)
            {
                DateTime transactionsDate = item.Key;
                List<CustomerDirectDebitInitiationPayment> transactionsList = item.Value;
                decimal transactionsSum = 0;
                foreach (var payment in transactionsList) transactionsSum += payment.Amount;

                // Añadimos la cabecera de cada bloque PaymentInfo (el cual depende de la fecha a la que se realice el cargo/abono).

                document.CstmrDrctDbtInitn.PmtInf[++index] = new PaymentInstruction()
                {
                    PmtInfId = PaymentInformationIdentification,
                    PmtMtd = PaymentMethodCode.DD,
                    BtchBookg = true,
                    NbOfTxs = $"{transactionsList.Count}",
                    CtrlSum = transactionsSum,
                    PmtTpInf = new PaymentTypeInformation()
                    {
                        SvcLvl = new CdOrPrtryTypeChoice()
                        {
                            Item = ServiceLevel
                        },
                        LclInstrm = new CdOrPrtryTypeChoice()
                        {
                            Item = LocalInstrument
                        },
                        SeqTp = SequenceTypeCode.RCUR,
                        SeqTpSpecified = true,
                        CtgyPurp = new CdOrPrtryTypeChoice()
                        {
                            Item = CategoryPurpose
                        },
                        CtgyPurpSpecified = true
                    },
                    ReqdColltnDt = transactionsDate, // Fecha de abono
                    Cdtr = new PartyIdentification()
                    {
                        Nm = Creditor.Name
                    },
                    CdtrAcct = new CashAccount()
                    {
                        Id = new AccountIdentificationChoice()
                        {
                            Item = Creditor.IBAN,
                            ItemElementName = AccountIdentificationType.IBAN
                        }
                    },
                    CdtrAgt = new BranchAndFinancialInstitutionIdentification()
                    {
                        FinInstnId = new FinancialInstitutionIdentification()
                        {
                            BICFI = Creditor.BIC
                        }
                    },
                    CdtrSchmeId = new PartyIdentification()
                    {
                        Id = new PartyChoice()
                        {
                            Item = new PersonIdentification()
                            {
                                Othr = new GenericIdentificationCdOrPrtry[1]
                                    {
                                        new GenericIdentificationCdOrPrtry()
                                        {
                                            Id = Creditor.Identification,
                                            SchmeNm = new CdOrPrtryTypeChoice()
                                            {
                                                Item = Creditor.SchmeNm,
                                                ItemElementName = CdOrPrtryType.Prtry
                                            }
                                        }
                                    }
                            }
                        }
                    },
                    DrctDbtTxInf = new DirectDebitTransactionInformation[transactionsList.Count]
                };

                // Añadimos las líneas al bloque de PaymentInfo.

                foreach (var directDebitTransaction in transactionsList)
                {
                    directDebitTransaction.PaymentIdentification = $"{MessageIdentification}-" + $"{++transactionIndex + 1}".PadLeft(3, '0');

                    document.CstmrDrctDbtInitn.PmtInf[index].DrctDbtTxInf[transactionIndex] = new DirectDebitTransactionInformation()
                    {
                        PmtId = new PaymentIdentification()
                        {
                            EndToEndId = directDebitTransaction.PaymentIdentification,
                            InstrId = directDebitTransaction.PaymentIdentification
                        },
                        InstdAmt = new ActiveOrHistoricCurrencyAndAmount()
                        {
                            Ccy = directDebitTransaction.Currency,
                            Value = directDebitTransaction.Amount
                        },
                        DrctDbtTx = new PaymentTransaction()
                        {
                            MndtRltdInf = new MandateRelatedInformation()
                            {
                                MndtId = directDebitTransaction.MandateIdentification,
                                DtOfSgntr = directDebitTransaction.DateOfSignature,     // Fecha de firma
                                DtOfSgntrSpecified = true,
                                AmdmntInd = false,
                                AmdmntIndSpecified = true
                            }
                        },
                        DbtrAgt = new BranchAndFinancialInstitutionIdentification()
                        {
                            FinInstnId = new FinancialInstitutionIdentification()
                            {
                                BIC = directDebitTransaction.Debtor.BIC
                            }
                        },
                        Dbtr = new PartyIdentification()
                        {
                            Nm = directDebitTransaction.Debtor.Name
                        },
                        DbtrAcct = new CashAccount()
                        {
                            Id = new AccountIdentificationChoice()
                            {
                                Item = directDebitTransaction.Debtor.IBAN,
                                ItemElementName = AccountIdentificationType.IBAN
                            }
                        },
                        Purp = new CdOrPrtryTypeChoice()
                        {
                            Item = directDebitTransaction.Purpose
                        },
                        RmtInf = new RemittanceInformation()
                        {
                            Ustrd = directDebitTransaction.RemittanceInformation
                        }
                    };
                }

                transactionIndex = -1;
            }

            return XmlParser<Xml.Pain.CustomerDirectDebitInitiationV08.Document>.ToXml(document);
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
                return DirectDebitTransactions == null ? 0 : DirectDebitTransactions.Count; 
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

                if (DirectDebitTransactions == null)
                    return sum;

                foreach (var directDebitTransaction in DirectDebitTransactions)
                    sum += directDebitTransaction.Amount;

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
        /// Acreedor emisor del Direct Debit.
        /// </summary>
        public CustomerDirectDebitInitiationParty Creditor { get; set; }

        /// <summary>
        /// Proporciona más detalles específicos de las transacciones de débito directo individuales incluidas en el mensaje.
        /// </summary>
        public List<CustomerDirectDebitInitiationPayment> DirectDebitTransactions { get; set; }

        /// <summary>
        /// Constructor.
        /// </summary>
        public CustomerDirectDebitInitiation() 
        {

            ServiceLevel = "SEPA";
            LocalInstrument = "COR1";
            CategoryPurpose = "CASH";

            _Parsers[CustomerDirectDebitInitiationVersions.V02] = GetXmlV02;
            _Parsers[CustomerDirectDebitInitiationVersions.V08] = GetXmlV08;

        }

        /// <summary>
        /// Devuelve el archivo xml correspondiente.
        /// </summary>
        /// <param name="version">Versión a utilizar.</param>
        /// <returns>Archivo xml correspondiente</returns>
        public byte[] GetXml(CustomerDirectDebitInitiationVersions version = CustomerDirectDebitInitiationVersions.V02) 
        {
            if (!_Parsers.ContainsKey(version))
                throw new NotImplementedException($"Version {version} not implemented.");

            return _Parsers[version]();
        }
    }
}
