using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV04
{
    public partial class ReferredDocumentInformation3
    {


        public ReferredDocumentType2 Tp { get; set; }


        public string Nb { get; set; }


        [XmlElement(DataType = "date")]
        public System.DateTime RltdDt { get; set; }


        [XmlIgnore()]
        public bool RltdDtSpecified { get; set; }

    }


}

