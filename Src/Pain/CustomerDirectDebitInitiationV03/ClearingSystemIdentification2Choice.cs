using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03")]
    public partial class ClearingSystemIdentification2Choice
    {

        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }

        [XmlIgnore()]
        public ItemChoiceType2 ItemElementName { get; set; }

    }



}

