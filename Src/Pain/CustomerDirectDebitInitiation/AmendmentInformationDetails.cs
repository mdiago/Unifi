using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    [Serializable()]
    public partial class AmendmentInformationDetails
    {


        public string OrgnlMndtId { get; set; }

        public PartyIdentification OrgnlCdtrSchmeId { get; set; }

        public BranchAndFinancialInstitutionIdentification OrgnlCdtrAgt { get; set; }

        public CashAccount OrgnlCdtrAgtAcct { get; set; }

        public PartyIdentification OrgnlDbtr { get; set; }

        public CashAccount OrgnlDbtrAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification OrgnlDbtrAgt { get; set; }

        public CashAccount OrgnlDbtrAgtAcct { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime OrgnlFnlColltnDt { get; set; }

        [XmlIgnore()]
        public bool OrgnlFnlColltnDtSpecified { get; set; }

        [XmlElement("OrgnlFrqcy", typeof(FrequencyCode), Namespace = Namespaces.V02)]
        [XmlElement("OrgnlFrqcy", typeof(FrequencyChoice), Namespace = Namespaces.V08)]
        public virtual object OrgnlFrqcy { get; set; }

        [XmlIgnore()]
        public bool OrgnlFrqcySpecified { get; set; }

    }

}
