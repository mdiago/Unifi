using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV04
{
    public partial class DirectDebitTransaction7
    {
        public MandateRelatedInformation8 MndtRltdInf { get; set; }


        public PartyIdentification CdtrSchmeId { get; set; }


        public string PreNtfctnId { get; set; }


        [XmlElement(DataType = "date")]
        public System.DateTime PreNtfctnDt { get; set; }


        [XmlIgnore()]
        public bool PreNtfctnDtSpecified { get; set; }
    }


}

