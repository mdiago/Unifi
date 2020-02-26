using System;
using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class DirectDebitTransaction7
    {

        public MandateRelatedInformation8 MndtRltdInf { get; set; }

        public PartyIdentification43 CdtrSchmeId { get; set; }

        public string PreNtfctnId { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime PreNtfctnDt { get; set; }

        [XmlIgnore()]
        public bool PreNtfctnDtSpecified { get; set; }

    }



}

