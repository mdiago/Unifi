using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class DirectDebitTransaction6
    {

        public MandateRelatedInformation6 MndtRltdInf { get; set; }

        public PartyIdentification32 CdtrSchmeId { get; set; }

        public string PreNtfctnId { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime PreNtfctnDt { get; set; }

        [XmlIgnore()]
        public bool PreNtfctnDtSpecified { get; set; }

    }


}

