using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{

    public partial class PaymentInstructionInformation2
    {

        public string PmtInfId { get; set; }

        public PaymentMethodCode PmtMtd { get; set; }

        public PaymentTypeInformation PmtTpInf { get; set; }


        [XmlElement(DataType = "date")]
        public DateTime ReqdColltnDt { get; set; }


        public PartyIdentification Cdtr { get; set; }

        public CashAccount CdtrAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification CdtrAgt { get; set; }

        public CashAccount CdtrAgtAcct { get; set; }

        public PartyIdentification UltmtCdtr { get; set; }

        public ChargeBearerTypeCode ChrgBr { get; set; }

        [XmlIgnore()]
        public bool ChrgBrSpecified { get; set; }

        public CashAccount ChrgsAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification ChrgsAcctAgt { get; set; }


        [XmlElement("DrctDbtTxInf")]
        public DirectDebitTransactionInformation1[] DrctDbtTxInf { get; set; }

    }


}
