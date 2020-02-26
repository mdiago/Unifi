using System.Xml.Serialization;
using System;
using Unifi.Pain;


namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{

    public partial class PersonIdentification3
    {


        [XmlElement("AlnRegnNb", typeof(string))]
        [XmlElement("CstmrNb", typeof(string))]
        [XmlElement("DrvrsLicNb", typeof(string))]
        [XmlElement("DtAndPlcOfBirth", typeof(DateAndPlaceOfBirth))]
        [XmlElement("IdntyCardNb", typeof(string))]
        [XmlElement("MplyrIdNb", typeof(string))]
        [XmlElement("OthrId", typeof(GenericIdentification4))]
        [XmlElement("PsptNb", typeof(string))]
        [XmlElement("SclSctyNb", typeof(string))]
        [XmlElement("TaxIdNb", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public object Item { get; set; }


        [XmlIgnore()]
        public ItemChoiceType ItemElementName { get; set; }


        public string Issr { get; set; }

    }


}
