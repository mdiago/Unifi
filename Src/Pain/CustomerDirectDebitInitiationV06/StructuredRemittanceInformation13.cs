using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV06
{
    public partial class StructuredRemittanceInformation13
    {

        
        [XmlElement("RfrdDocInf")]
        public ReferredDocumentInformation7[] RfrdDocInf { get; set; }

        public RemittanceAmount2 RfrdDocAmt { get; set; }

        public CreditorReferenceInformation2 CdtrRefInf { get; set; }

        public PartyIdentification Invcr { get; set; }

        public PartyIdentification Invcee { get; set; }

        public TaxInformation4 TaxRmt { get; set; }

        public Garnishment1 GrnshmtRmt { get; set; }

        [XmlElement("AddtlRmtInf")]
        public string[] AddtlRmtInf { get; set; }

    }



}

