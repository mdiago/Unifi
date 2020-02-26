using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class RemittanceInformation7
    {

    
        [XmlElement("Ustrd")]
        public string[] Ustrd { get; set; }

        [XmlElement("Strd")]
        public StructuredRemittanceInformation9[] Strd { get; set; }

    }



}

