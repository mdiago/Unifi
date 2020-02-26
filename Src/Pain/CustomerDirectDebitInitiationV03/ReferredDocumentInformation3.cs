using System;
using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class ReferredDocumentInformation3
    {

    
        public ReferredDocumentType2 Tp { get; set; }

        public string Nb { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime RltdDt { get; set; }

        [XmlIgnore()]
        public bool RltdDtSpecified { get; set; }

    }



}

