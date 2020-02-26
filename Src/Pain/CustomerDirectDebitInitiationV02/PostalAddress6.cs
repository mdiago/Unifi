using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class PostalAddress6
    {

        public AddressType2Code AdrTp { get; set; }

        [XmlIgnore()]
        public bool AdrTpSpecified { get; set; }

        public string Dept { get; set; }

        public string SubDept { get; set; }

        public string StrtNm { get; set; }

        public string BldgNb { get; set; }

        public string PstCd { get; set; }

        public string TwnNm { get; set; }

        public string CtrySubDvsn { get; set; }

        public string Ctry { get; set; }

        [XmlElement("AdrLine")]
        public string[] AdrLine { get; set; }

    }

}
