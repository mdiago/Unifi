using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    public partial class CustomerDirectDebitInitiationV07
    {

        public GroupHeader55 GrpHdr { get; set; }

        
        [XmlElement("PmtInf")]
        public PaymentInstruction21[] PmtInf { get; set; }


        [XmlElement("SplmtryData")]
        public SupplementaryData[] SplmtryData { get; set; }

    }


}

