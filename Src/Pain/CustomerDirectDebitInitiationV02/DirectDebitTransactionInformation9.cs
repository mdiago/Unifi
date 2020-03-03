using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class DirectDebitTransactionInformation9
    {

        public PaymentIdentification PmtId { get; set; }

        public PaymentTypeInformation PmtTpInf { get; set; }

        public ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        public ChargeBearerTypeCode ChrgBr { get; set; } 

        [XmlIgnore()]
        public bool ChrgBrSpecified { get; set; }

        public DirectDebitTransaction DrctDbtTx { get; set; }

        public PartyIdentification UltmtCdtr { get; set; }

        public BranchAndFinancialInstitutionIdentification DbtrAgt { get; set; }

        public CashAccount DbtrAgtAcct { get; set; }

        public PartyIdentification Dbtr { get; set; }

        public CashAccount DbtrAcct { get; set; }

        public PartyIdentification UltmtDbtr { get; set; }

        public string InstrForCdtrAgt { get; set; }

        public CdOrPrtryTypeChoice Purp { get; set; }   

        [XmlElement("RgltryRptg")]
        public RegulatoryReporting[] RgltryRptg { get; set; }

        public TaxInformation Tax { get; set; }

        [XmlElement("RltdRmtInf")]
        public RemittanceLocation2[] RltdRmtInf { get; set; }

        public RemittanceInformation5 RmtInf { get; set; }

    }


}

