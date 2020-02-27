using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{

    public partial class DirectDebitTransaction1
    {


        public MandateRelatedInformation1 MndtRltdInf { get; set; }


        public PartyIdentification CdtrSchmeId { get; set; }

        public string PreNtfctnId { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime PreNtfctnDt { get; set; }


        [XmlIgnore()]
        public bool PreNtfctnDtSpecified { get; set; }

    }

}
