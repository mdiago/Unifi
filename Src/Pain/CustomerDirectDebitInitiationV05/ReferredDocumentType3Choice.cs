using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV05
{
    public partial class ReferredDocumentType3Choice
    {
        [XmlElement("Cd", typeof(CommercialDocumentTypeCode))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }



}

