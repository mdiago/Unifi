using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class RemittanceLocation2
    {

    
        public string RmtId { get; set; }

        public RemittanceLocationMethod2Code RmtLctnMtd { get; set; }

        [XmlIgnore()]
        public bool RmtLctnMtdSpecified { get; set; }

        public string RmtLctnElctrncAdr { get; set; }

        public NameAndAddress RmtLctnPstlAdr { get; set; }

    }



}

