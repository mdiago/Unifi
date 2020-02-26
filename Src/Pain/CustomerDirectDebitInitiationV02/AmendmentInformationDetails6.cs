using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class AmendmentInformationDetails6
    {

        public string OrgnlMndtId { get; set; }

        public PartyIdentification32 OrgnlCdtrSchmeId { get; set; }

        public BranchAndFinancialInstitutionIdentification4 OrgnlCdtrAgt { get; set; }

        public CashAccount16 OrgnlCdtrAgtAcct { get; set; }

        public PartyIdentification32 OrgnlDbtr { get; set; }

        public CashAccount16 OrgnlDbtrAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification4 OrgnlDbtrAgt { get; set; }

        public CashAccount16 OrgnlDbtrAgtAcct { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime OrgnlFnlColltnDt { get; set; }

        [XmlIgnore()]
        public bool OrgnlFnlColltnDtSpecified { get; set; }

        public Frequency1Code OrgnlFrqcy { get; set; }

        [XmlIgnore()]
        public bool OrgnlFrqcySpecified { get; set; }

    }


}

