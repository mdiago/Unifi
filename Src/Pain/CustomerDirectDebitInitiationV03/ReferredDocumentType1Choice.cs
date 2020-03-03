using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{


    public partial class ReferredDocumentType1Choice
    {

    
        [XmlElement("Cd", typeof(CommercialDocumentTypeCode))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }



}

