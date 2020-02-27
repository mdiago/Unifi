using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV05
{
    public partial class ReferredDocumentInformation6
    {
        public ReferredDocumentType4 Tp { get; set; }

        public string Nb { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime RltdDt { get; set; }

        [XmlIgnore()]
        public bool RltdDtSpecified { get; set; }

    }



}

