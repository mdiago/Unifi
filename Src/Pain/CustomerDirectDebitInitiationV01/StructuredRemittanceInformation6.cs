using System.Xml.Serialization;
using System;
using Unifi.Pain;

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


        public CreditorReferenceInformation1 CdtrRefInf { get; set; }


        public PartyIdentification8 Invcr { get; set; }


        public PartyIdentification8 Invcee { get; set; }


        public string AddtlRmtInf { get; set; }

    }
}
