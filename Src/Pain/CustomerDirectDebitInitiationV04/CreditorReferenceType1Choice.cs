﻿using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV04
{
    public partial class CreditorReferenceType1Choice
    {
        [XmlElement("Cd", typeof(DocumentType3Code))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }
    }


}

