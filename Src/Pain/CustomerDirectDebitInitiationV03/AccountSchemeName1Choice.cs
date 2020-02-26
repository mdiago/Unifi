﻿using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class AccountSchemeName1Choice
    {

    
        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item { get; set; }

        [XmlIgnore()]
        public ItemChoiceType7 ItemElementName { get; set; }

    }



}
