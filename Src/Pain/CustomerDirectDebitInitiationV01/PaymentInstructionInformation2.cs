using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{

    public partial class PaymentInstructionInformation2
    {

        public string PmtInfId { get; set; }

        public PaymentMethod2Code PmtMtd { get; set; }

        public PaymentTypeInformation2 PmtTpInf { get; set; }


        [XmlElement(DataType = "date")]
        public DateTime ReqdColltnDt { get; set; }


        public PartyIdentification8 Cdtr { get; set; }

        public CashAccount7 CdtrAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification3 CdtrAgt { get; set; }

        public CashAccount7 CdtrAgtAcct { get; set; }

        public PartyIdentification8 UltmtCdtr { get; set; }

        public ChargeBearerType1Code ChrgBr { get; set; }

        [XmlIgnore()]
        public bool ChrgBrSpecified { get; set; }

        public CashAccount7 ChrgsAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification3 ChrgsAcctAgt { get; set; }


        [XmlElement("DrctDbtTxInf")]
        public DirectDebitTransactionInformation1[] DrctDbtTxInf { get; set; }

    }


}
