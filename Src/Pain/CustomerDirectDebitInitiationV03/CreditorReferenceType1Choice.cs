using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class CreditorReferenceType1Choice
    {

        private object itemField;

    
        [XmlElement("Cd", typeof(DocumentType3Code))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }



}

