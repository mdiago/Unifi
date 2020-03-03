﻿using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    public partial class StructuredRemittanceInformation13
    {

        
        [XmlElement("RfrdDocInf")]
        public ReferredDocumentInformation7[] RfrdDocInf { get; set; }

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
