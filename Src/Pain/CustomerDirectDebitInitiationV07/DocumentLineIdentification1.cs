using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    public partial class DocumentLineIdentification1
    {

        public DocumentLineType1 Tp { get; set; }

        public string Nb { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime RltdDt { get; set; }

        [XmlIgnore()]
        public bool RltdDtSpecified { get; set; }

    }


}

