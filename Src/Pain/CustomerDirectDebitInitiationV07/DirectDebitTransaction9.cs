using System;
using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    public partial class DirectDebitTransaction9
    {

        public MandateRelatedInformation11 MndtRltdInf { get; set; }

        public PartyIdentification CdtrSchmeId { get; set; }

        public string PreNtfctnId { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime PreNtfctnDt { get; set; }

        [XmlIgnore()]
        public bool PreNtfctnDtSpecified { get; set; }

    }


}

