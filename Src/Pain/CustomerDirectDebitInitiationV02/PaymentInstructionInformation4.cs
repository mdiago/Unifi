using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class PaymentInstructionInformation4
    {

        public string PmtInfId { get; set; }

        public PaymentMethod2Code PmtMtd { get; set; }

        public bool BtchBookg { get; set; }

        [XmlIgnore()]
        public bool BtchBookgSpecified { get; set; }

        public string NbOfTxs { get; set; }

        public decimal CtrlSum { get; set; }

        [XmlIgnore()]
        public bool CtrlSumSpecified { get; set; }

        public PaymentTypeInformation20 PmtTpInf { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime ReqdColltnDt { get; set; }

        public PartyIdentification32 Cdtr { get; set; }

        public CashAccount16 CdtrAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification4 CdtrAgt { get; set; }

        public CashAccount16 CdtrAgtAcct { get; set; }

        public PartyIdentification32 UltmtCdtr { get; set; }

        public ChargeBearerType1Code ChrgBr { get; set; }

        [XmlIgnore()]
        public bool ChrgBrSpecified { get; set; }

        public CashAccount16 ChrgsAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification4 ChrgsAcctAgt { get; set; }

        public PartyIdentification32 CdtrSchmeId { get; set; }

        [XmlElement("DrctDbtTxInf")]
        public DirectDebitTransactionInformation9[] DrctDbtTxInf { get; set; }

    }


}

