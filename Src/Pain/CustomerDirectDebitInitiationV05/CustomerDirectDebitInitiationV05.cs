using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV05
{
    public partial class CustomerDirectDebitInitiationV05
    {
        public GroupHeader55 GrpHdr { get; set; }

        [XmlElement("PmtInf")]
        public PaymentInstruction15[] PmtInf { get; set; }

        [XmlElement("SplmtryData")]
        public SupplementaryData[] SplmtryData { get; set; }

    }



}

