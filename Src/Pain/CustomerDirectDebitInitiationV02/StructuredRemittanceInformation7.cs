using System;
using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class StructuredRemittanceInformation7
    {

        [XmlElement("RfrdDocInf")]
        public ReferredDocumentInformation3[] RfrdDocInf { get; set; }

        public RemittanceAmount1 RfrdDocAmt { get; set; }

        public CreditorReferenceInformation CdtrRefInf { get; set; }

        public PartyIdentification Invcr { get; set; }

        public PartyIdentification Invcee { get; set; }


        [XmlElement("AddtlRmtInf")]
        public string[] AddtlRmtInf { get; set; }

    }

}
