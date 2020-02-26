using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class CreditorReferenceType1
    {


        [XmlElement("Cd", typeof(DocumentType3Code))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }


        public string Issr { get; set; }

    }
}
