using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03")]
    public partial class CustomerDirectDebitInitiationV03
    {

        public GroupHeader55 GrpHdr { get; set; }

        [XmlElement("PmtInf")]
        public PaymentInstruction7[] PmtInf { get; set; }

        [XmlElement("SplmtryData")]
        public SupplementaryData1[] SplmtryData { get; set; }

    }



}

