using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV05
{
    public partial class RegulatoryReporting3
    {
        public RegulatoryReportingType1Code DbtCdtRptgInd { get; set; }

        [XmlIgnore()]
        public bool DbtCdtRptgIndSpecified { get; set; }

        public RegulatoryAuthority2 Authrty { get; set; }

        [XmlElement("Dtls")]
        public StructuredRegulatoryReporting3[] Dtls { get; set; }

    }



}

