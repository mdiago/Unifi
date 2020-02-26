using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class CategoryPurpose1Choice
    {

        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }

        [XmlIgnore()]
        public ItemChoiceType6 ItemElementName { get; set; }

    }


}

