using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV06
{
    public partial class ReferredDocumentType3Choice
    {

        
        [XmlElement("Cd", typeof(DocumentType6Code))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }



}

