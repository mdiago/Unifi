using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV06
{
    public partial class DocumentLineInformation1
    {

        
        [XmlElement("Id")]
        public DocumentLineIdentification1[] Id { get; set; }

        public string Desc { get; set; }

        public RemittanceAmount3 Amt { get; set; }

    }



}

