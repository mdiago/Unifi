using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV04
{
    public partial class CustomerDirectDebitInitiationV04
    {
        public GroupHeader55 GrpHdr { get; set; }


        [XmlElement("PmtInf")]
        public PaymentInstruction10[] PmtInf { get; set; }


        [XmlElement("SplmtryData")]
        public SupplementaryData[] SplmtryData { get; set; }
    }


}

