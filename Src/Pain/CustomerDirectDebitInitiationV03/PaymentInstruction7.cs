using System;
using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class PaymentInstruction7
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

        public PaymentTypeInformation24 PmtTpInf { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime ReqdColltnDt { get; set; }

        public PartyIdentification43 Cdtr { get; set; }

        public CashAccount24 CdtrAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification5 CdtrAgt { get; set; }

        public CashAccount24 CdtrAgtAcct { get; set; }

        public PartyIdentification43 UltmtCdtr { get; set; }

        public ChargeBearerType1Code ChrgBr { get; set; }

        [XmlIgnore()]
        public bool ChrgBrSpecified { get; set; }

        public CashAccount24 ChrgsAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification5 ChrgsAcctAgt { get; set; }

        public PartyIdentification43 CdtrSchmeId { get; set; }

        [XmlElement("DrctDbtTxInf")]
        public DirectDebitTransactionInformation11[] DrctDbtTxInf { get; set; }

    }



}

