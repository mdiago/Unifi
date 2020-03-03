﻿using System;
using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class ReferredDocumentType1Choice
    {

        [XmlElement("Cd", typeof(CommercialDocumentTypeCode))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }

}
