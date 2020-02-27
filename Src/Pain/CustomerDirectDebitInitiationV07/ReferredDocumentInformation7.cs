using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    public partial class ReferredDocumentInformation7
    {

        
        public ReferredDocumentType4 Tp { get; set; }

        public string Nb { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime RltdDt { get; set; }

        [XmlIgnore()]
        public bool RltdDtSpecified { get; set; }


        [XmlElement("LineDtls")]
        public DocumentLineInformation1[] LineDtls { get; set; }

    }


}

