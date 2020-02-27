using System;
using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    public partial class AmendmentInformationDetails11
    {

        
        public string OrgnlMndtId { get; set; }

        public PartyIdentification OrgnlCdtrSchmeId { get; set; }

        public BranchAndFinancialInstitutionIdentification5 OrgnlCdtrAgt { get; set; }

        public CashAccount24 OrgnlCdtrAgtAcct { get; set; }

        public PartyIdentification OrgnlDbtr { get; set; }

        public CashAccount24 OrgnlDbtrAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification5 OrgnlDbtrAgt { get; set; }

        public CashAccount24 OrgnlDbtrAgtAcct { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime OrgnlFnlColltnDt { get; set; }

        [XmlIgnore()]
        public bool OrgnlFnlColltnDtSpecified { get; set; }

        public Frequency36Choice OrgnlFrqcy { get; set; }

        public CdOrPrtryTypeChoice OrgnlRsn { get; set; }

        public string OrgnlTrckgDays { get; set; }

    }


}

