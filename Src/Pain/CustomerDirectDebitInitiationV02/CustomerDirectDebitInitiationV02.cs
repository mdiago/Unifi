using System;
using System.Xml.Serialization;


namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class CustomerDirectDebitInitiationV02
    {

        public GroupHeader39 GrpHdr { get; set; }

        [XmlElement("PmtInf")]
        public PaymentInstructionInformation4[] PmtInf { get; set; }

    }

}
