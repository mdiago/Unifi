using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV05
{
    public partial class RemittanceLocation4
    {
        public string RmtId { get; set; }

        [XmlElement("RmtLctnDtls")]
        public RemittanceLocationDetails1[] RmtLctnDtls { get; set; }

    }



}

