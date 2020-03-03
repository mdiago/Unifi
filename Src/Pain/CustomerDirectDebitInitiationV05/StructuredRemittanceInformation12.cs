using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV05
{
    public partial class StructuredRemittanceInformation12
    {
        [XmlElement("RfrdDocInf")]
        public ReferredDocumentInformation6[] RfrdDocInf { get; set; }

        public RemittanceAmount2 RfrdDocAmt { get; set; }

        public CreditorReferenceInformation CdtrRefInf { get; set; }

        public PartyIdentification Invcr { get; set; }

        public PartyIdentification Invcee { get; set; }

        public TaxInformation TaxRmt { get; set; }

        public Garnishment1 GrnshmtRmt { get; set; }

        [XmlElement("AddtlRmtInf")]
        public string[] AddtlRmtInf { get; set; }

    }



}

