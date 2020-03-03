﻿using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV04
{
    public partial class StructuredRemittanceInformation9
    {


        [XmlElement("RfrdDocInf")]
        public ReferredDocumentInformation3[] RfrdDocInf { get; set; }


        public RemittanceAmount2 RfrdDocAmt { get; set; }


        public CreditorReferenceInformation CdtrRefInf { get; set; }


        public PartyIdentification Invcr { get; set; }


        public PartyIdentification Invcee { get; set; }


        [XmlElement("AddtlRmtInf")]
        public string[] AddtlRmtInf { get; set; }

    }


}
