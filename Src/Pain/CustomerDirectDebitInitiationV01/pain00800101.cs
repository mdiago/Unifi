using System.Xml.Serialization;
using System;
using Unifi.Pain;


namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    [XmlType(TypeName = "pain.008.001.01")]
    public partial class pain00800101
    {

        public GroupHeader1 GrpHdr { get; set; }

        [XmlElement("PmtInf")]
        public PaymentInstructionInformation2[] PmtInf { get; set; }

    }
}
