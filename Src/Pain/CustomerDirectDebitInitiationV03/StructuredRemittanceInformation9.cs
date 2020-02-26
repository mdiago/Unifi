using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class StructuredRemittanceInformation9
    {

    
        [XmlElement("RfrdDocInf")]
        public ReferredDocumentInformation3[] RfrdDocInf { get; set; }

        public RemittanceAmount2 RfrdDocAmt { get; set; }

        public CreditorReferenceInformation2 CdtrRefInf { get; set; }

        public PartyIdentification43 Invcr { get; set; }

        public PartyIdentification43 Invcee { get; set; }

        [XmlElement("AddtlRmtInf")]
        public string[] AddtlRmtInf { get; set; }

    }



}

