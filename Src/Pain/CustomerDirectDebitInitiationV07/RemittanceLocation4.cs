using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    public partial class RemittanceLocation4
    {

        
        public string RmtId { get; set; }

        [XmlElement("RmtLctnDtls")]
        public RemittanceLocationDetails1[] RmtLctnDtls { get; set; }

    }


}

