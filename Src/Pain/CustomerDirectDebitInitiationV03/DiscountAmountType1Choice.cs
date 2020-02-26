using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class DiscountAmountType1Choice
    {

    
        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }

        [XmlIgnore()]
        public ItemChoiceType10 ItemElementName { get; set; }

    }



}

