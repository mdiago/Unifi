using System;
using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class AmendmentInformationDetails8
    {


        public string OrgnlMndtId { get; set; }

        public PartyIdentification43 OrgnlCdtrSchmeId { get; set; }

        public BranchAndFinancialInstitutionIdentification5 OrgnlCdtrAgt { get; set; }

        public CashAccount24 OrgnlCdtrAgtAcct { get; set; }

        public PartyIdentification43 OrgnlDbtr { get; set; }

        public CashAccount24 OrgnlDbtrAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification5 OrgnlDbtrAgt { get; set; }

        public CashAccount24 OrgnlDbtrAgtAcct { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime OrgnlFnlColltnDt { get; set; }

        [XmlIgnore()]
        public bool OrgnlFnlColltnDtSpecified { get; set; }

        public Frequency6Code OrgnlFrqcy { get; set; }

        [XmlIgnore()]
        public bool OrgnlFrqcySpecified { get; set; }

    }



}

