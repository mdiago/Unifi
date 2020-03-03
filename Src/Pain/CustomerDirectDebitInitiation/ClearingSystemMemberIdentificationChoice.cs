using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{
    public partial class ClearingSystemMemberIdentificationChoice
    {

        [XmlElement("Id", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }


        [XmlIgnore()]
        public IdOrPrtryType ItemElementName { get; set; }

    }

}
