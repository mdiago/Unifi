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
using System.Xml.Serialization;

namespace Unifi.Xml.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// Características que se aplican al lado de crédito de las transacciones
    /// de pago incluidas en el inicio del débito directo.
    /// </summary>
    [Serializable()]
    public class PaymentInstruction
    {

        /// <summary>
        /// Identificación única, según lo asignado por una parte que envía,
        /// para identificar inequívocamente el grupo de información de pago
        /// dentro del mensaje.
        /// </summary>
        public string PmtInfId { get; set; }

        /// <summary>
        /// Especifica los medios de pago que se utilizarán para mover la
        /// cantidad de dinero.
        /// </summary>
        public PaymentMethodCode PmtMtd { get; set; }

        /// <summary>
        /// Identifica si se solicita una sola entrada por transacción individual
        /// o una entrada por lotes para la suma de los importes de todas las transacciones
        /// dentro del grupo de un mensaje.
        /// Uso: la reserva de lotes se utiliza para solicitar y no solicitar una posible
        /// reserva de lotes.
        /// </summary>
        public bool BtchBookg { get; set; }

        [XmlIgnore()]
        public bool BtchBookgSpecified { get; set; }

        /// <summary>
        /// Número de transacciones individuales contenidas en el grupo
        /// de información de pago.
        /// </summary>
        public string NbOfTxs { get; set; }

        /// <summary>
        /// Total de todas las cantidades individuales incluidas en el grupo,
        /// independientemente de las monedas.
        /// </summary>
        public decimal CtrlSum { get; set; }

        [XmlIgnore()]
        public bool CtrlSumSpecified { get; set; }

        /// <summary>
        /// Conjunto de elementos utilizados para especificar aún más el tipo de transacción.
        /// </summary>
        public PaymentTypeInformation PmtTpInf { get; set; }

        /// <summary>
        /// Fecha y hora en que el acreedor solicita que la cantidad de dinero se recaude del deudor.
        /// Fecha en que la parte iniciadora solicita al agente de compensación que procese el pago.
        /// Uso: Esta es la fecha en que se debitará la cuenta del deudor. Si pago con cheque, la
        /// fecha en que el banco debe generar el cheque.
        /// </summary>
        [XmlElement(DataType = "date")]
        public DateTime ReqdColltnDt { get; set; }

        /// <summary>
        /// Parte a la que se le debe una cantidad de dinero.
        /// </summary>
        public PartyIdentification Cdtr { get; set; }

        /// <summary>
        /// Identificación inequívoca de la cuenta del acreedor en la que se registrará
        /// una entrada de crédito como resultado de la transacción de pago.
        /// </summary>
        public CashAccount CdtrAcct { get; set; }

        /// <summary>
        /// Institución financiera que presta servicios a una cuenta para el acreedor.
        /// </summary>
        public BranchAndFinancialInstitutionIdentification CdtrAgt { get; set; }

        /// <summary>
        /// Identificación inequívoca de la cuenta del agente acreedor en su agente
        /// de servicio en la cadena de pago.
        /// </summary>
        public CashAccount CdtrAgtAcct { get; set; }

        /// <summary>
        /// Acreedor final a la que se debe una cantidad de dinero.
        /// </summary>
        public PartyIdentification UltmtCdtr { get; set; }

        /// <summary>
        /// Especifica qué parte / partes asumirán los cargos asociados con
        /// el procesamiento de la transacción de pago.
        /// </summary>
        public ChargeBearerTypeCode ChrgBr { get; set; }

        [XmlIgnore()]
        public bool ChrgBrSpecified { get; set; }

        /// <summary>
        /// Cuenta utilizada para procesar cargos asociados con una transacción.
        /// Uso: La cuenta de cargos debe usarse cuando los cargos tienen que
        /// registrarse en una cuenta diferente de la cuenta identificada
        /// en la cuenta del deudor.
        /// </summary>
        public CashAccount ChrgsAcct { get; set; }

        /// <summary>
        /// Agente que presta servicios a una cuenta de cargos.
        /// Uso: El agente de la cuenta de cargos solo debe usarse
        /// cuando el agente de la cuenta de cargos es diferente
        /// del agente acreedor.
        /// </summary>
        public BranchAndFinancialInstitutionIdentification ChrgsAcctAgt { get; set; }

        /// <summary>
        /// Parte de crédito que firma el mandato.
        /// </summary>
        public PartyIdentification CdtrSchmeId { get; set; }

        /// <summary>
        /// Proporciona información sobre las transacciones individuales incluidas en el mensaje.
        /// </summary>
        [XmlElement("DrctDbtTxInf")]
        public DirectDebitTransactionInformation[] DrctDbtTxInf { get; set; }

        /// <summary>
        /// Representación textual de la instancia.
        /// </summary>
        /// <returns>Representación textual de la instancia.</returns>
        public override string ToString()
        {
            return $"{PmtInfId}, {PmtMtd}, {PmtTpInf}";
        }

    }
}
