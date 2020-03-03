using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class StructuredRemittanceInformation6
    {


        public ReferredDocumentInformation1 RfrdDocInf { get; set; }


        [XmlElement(DataType = "date")]
        public DateTime RfrdDocRltdDt { get; set; }


        [XmlIgnore()]
        public bool RfrdDocRltdDtSpecified { get; set; }


        [XmlElement("RfrdDocAmt")]
        public ReferredDocumentAmount1Choice[] RfrdDocAmt { get; set; }


        public CreditorReferenceInformation CdtrRefInf { get; set; }


        public PartyIdentification Invcr { get; set; }


        public PartyIdentification Invcee { get; set; }


        public string AddtlRmtInf { get; set; }

    }
}
