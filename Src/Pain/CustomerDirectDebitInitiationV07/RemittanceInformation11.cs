using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    public partial class RemittanceInformation11
    {

        [XmlElement("Ustrd")]
        public string[] Ustrd { get; set; }

        [XmlElement("Strd")]
        public StructuredRemittanceInformation13[] Strd { get; set; }

    }


}

