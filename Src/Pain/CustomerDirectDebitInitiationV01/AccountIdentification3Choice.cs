using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{

    public partial class AccountIdentification3Choice
    {


        [XmlElement("BBAN", typeof(string))]
        [XmlElement("IBAN", typeof(string))]
        [XmlElement("PrtryAcct", typeof(SimpleIdentificationInformation2))]
        [XmlElement("UPIC", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public object Item { get; set; }

        [XmlIgnore()]
        public ItemChoiceType3 ItemElementName { get; set; }

    }

}
