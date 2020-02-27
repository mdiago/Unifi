using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV05
{
    public partial class CreditorReferenceType1Choice
    {
        [XmlElement("Cd", typeof(DocumentType3Code))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }



}

