﻿using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{


    public partial class ReferredDocumentType1Choice
    {

    
        [XmlElement("Cd", typeof(DocumentType5Code))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }



}
