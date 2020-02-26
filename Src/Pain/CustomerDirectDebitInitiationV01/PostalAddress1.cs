using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{

    public partial class PostalAddress1
    {


        public AddressType2Code AdrTp { get; set; }


        [XmlIgnore()]
        public bool AdrTpSpecified { get; set; }


        [XmlElement("AdrLine")]
        public string[] AdrLine { get; set; }


        public string StrtNm { get; set; }


        public string BldgNb { get; set; }


        public string PstCd { get; set; }


        public string TwnNm { get; set; }


        public string CtrySubDvsn { get; set; }


        public string Ctry { get; set; }

    }
}
