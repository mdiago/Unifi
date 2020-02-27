using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{

    public partial class DirectDebitTransactionInformation1
    {

        public PaymentIdentification1 PmtId { get; set; }

        public PaymentTypeInformation2 PmtTpInf { get; set; }

        public CurrencyAndAmount InstdAmt { get; set; }

        public ChargeBearerType1Code ChrgBr { get; set; }

        [XmlIgnore()]
        public bool ChrgBrSpecified { get; set; }

        public DirectDebitTransaction1 DrctDbtTx { get; set; }

        public PartyIdentification UltmtCdtr { get; set; }

        public BranchAndFinancialInstitutionIdentification3 DbtrAgt { get; set; }
        public CashAccount7 DbtrAgtAcct { get; set; }

        public PartyIdentification Dbtr { get; set; }

        public CashAccount7 DbtrAcct { get; set; }

        public PartyIdentification UltmtDbtr { get; set; }

        public string InstrForCdtrAgt { get; set; }

        public CdOrPrtryTypeChoice Purp { get; set; }

        [XmlElement("RgltryRptg")]
        public RegulatoryReporting2[] RgltryRptg { get; set; }

        public TaxInformation2 Tax { get; set; }

        [XmlElement("RltdRmtInf")]
        public RemittanceLocation1[] RltdRmtInf { get; set; }

        public RemittanceInformation1 RmtInf { get; set; }

    }

}
