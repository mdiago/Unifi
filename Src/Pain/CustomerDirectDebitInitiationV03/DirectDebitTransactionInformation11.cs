using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03")]
    public partial class DirectDebitTransactionInformation11
    {

        public PaymentIdentification1 PmtId { get; set; }


        public PaymentTypeInformation24 PmtTpInf { get; set; }

        public ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        public ChargeBearerType1Code ChrgBr { get; set; }

        [XmlIgnore()]
        public bool ChrgBrSpecified { get; set; }

        public DirectDebitTransaction7 DrctDbtTx { get; set; }

        public PartyIdentification UltmtCdtr { get; set; }

        public BranchAndFinancialInstitutionIdentification5 DbtrAgt { get; set; }

        public CashAccount24 DbtrAgtAcct { get; set; }


        public PartyIdentification Dbtr { get; set; }

        public CashAccount24 DbtrAcct { get; set; }

        public PartyIdentification UltmtDbtr { get; set; }

        public string InstrForCdtrAgt { get; set; }

        public CdOrPrtryTypeChoice Purp { get; set; }

        [XmlElement("RgltryRptg")]
        public RegulatoryReporting3[] RgltryRptg { get; set; }

        public TaxInformation3 Tax { get; set; }

        [XmlElement("RltdRmtInf")]
        public RemittanceLocation2[] RltdRmtInf { get; set; }

        public RemittanceInformation7 RmtInf { get; set; }

    }



}

