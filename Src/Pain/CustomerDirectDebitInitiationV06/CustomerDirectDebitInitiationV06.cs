using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV06
{
    public partial class CustomerDirectDebitInitiationV06
    {

        
        public GroupHeader55 GrpHdr { get; set; }

        [XmlElement("PmtInf")]
        public PaymentInstruction18[] PmtInf { get; set; }

        [XmlElement("SplmtryData")]
        public SupplementaryData1[] SplmtryData { get; set; }

    }



}

