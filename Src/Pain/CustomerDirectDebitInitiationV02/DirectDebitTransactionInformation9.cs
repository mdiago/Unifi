using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class DirectDebitTransactionInformation9
    {

        public PaymentIdentification1 PmtId { get; set; }

        public PaymentTypeInformation20 PmtTpInf { get; set; }

        public ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        public ChargeBearerType1Code ChrgBr { get; set; } 

        [XmlIgnore()]
        public bool ChrgBrSpecified { get; set; }

        public DirectDebitTransaction6 DrctDbtTx { get; set; }

        public PartyIdentification32 UltmtCdtr { get; set; }

        public BranchAndFinancialInstitutionIdentification4 DbtrAgt { get; set; }

        public CashAccount16 DbtrAgtAcct { get; set; }

        public PartyIdentification32 Dbtr { get; set; }

        public CashAccount16 DbtrAcct { get; set; }

        public PartyIdentification32 UltmtDbtr { get; set; }

        public string InstrForCdtrAgt { get; set; }

        public CdOrPrtryTypeChoice Purp { get; set; }   

        [XmlElement("RgltryRptg")]
        public RegulatoryReporting3[] RgltryRptg { get; set; }

        public TaxInformation3 Tax { get; set; }

        [XmlElement("RltdRmtInf")]
        public RemittanceLocation2[] RltdRmtInf { get; set; }

        public RemittanceInformation5 RmtInf { get; set; }

    }


}

