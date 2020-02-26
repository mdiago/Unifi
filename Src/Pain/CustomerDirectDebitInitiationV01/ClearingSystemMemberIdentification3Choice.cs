using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class ClearingSystemMemberIdentification3Choice
    {

        [XmlElement("Id", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }


        [XmlIgnore()]
        public ItemChoiceType1 ItemElementName { get; set; }

    }

}
