using System;
using System.Xml.Serialization;


namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class StructuredRemittanceInformation7
    {

        [XmlElement("RfrdDocInf")]
        public ReferredDocumentInformation3[] RfrdDocInf { get; set; }

        public RemittanceAmount1 RfrdDocAmt { get; set; }

        public CreditorReferenceInformation2 CdtrRefInf { get; set; }

        public PartyIdentification32 Invcr { get; set; }

        public PartyIdentification32 Invcee { get; set; }


        [XmlElement("AddtlRmtInf")]
        public string[] AddtlRmtInf { get; set; }

    }

}
