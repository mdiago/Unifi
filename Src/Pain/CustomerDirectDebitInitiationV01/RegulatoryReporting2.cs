using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class RegulatoryReporting2
    {


        public RegulatoryReportingType1Code DbtCdtRptgInd { get; set; }

        [XmlIgnore()]
        public bool DbtCdtRptgIndSpecified { get; set; }

        public RegulatoryAuthority Authrty { get; set; }

        public StructuredRegulatoryReporting2 RgltryDtls { get; set; }

    }

}
