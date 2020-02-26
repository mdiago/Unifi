using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class Purpose1Choice
    {


        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }


        [XmlIgnore()]
        public ItemChoiceType4 ItemElementName { get; set; }

    }

}
