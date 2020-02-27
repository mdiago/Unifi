using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    public partial class CustomerDirectDebitInitiationV07
    {

        public GroupHeader55 GrpHdr { get; set; }

        
        [XmlElement("PmtInf")]
        public PaymentInstruction21[] PmtInf { get; set; }


        [XmlElement("SplmtryData")]
        public SupplementaryData1[] SplmtryData { get; set; }

    }


}

