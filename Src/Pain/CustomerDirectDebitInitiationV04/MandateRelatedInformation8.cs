using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV04
{
    public partial class MandateRelatedInformation8
    {
        public string MndtId { get; set; }


        [XmlElement(DataType = "date")]
        public System.DateTime DtOfSgntr { get; set; }


        [XmlIgnore()]
        public bool DtOfSgntrSpecified { get; set; }


        public bool AmdmntInd { get; set; }


        [XmlIgnore()]
        public bool AmdmntIndSpecified { get; set; }


        public AmendmentInformationDetails8 AmdmntInfDtls { get; set; }


        public string ElctrncSgntr { get; set; }


        [XmlElement(DataType = "date")]
        public System.DateTime FrstColltnDt { get; set; }


        [XmlIgnore()]
        public bool FrstColltnDtSpecified { get; set; }


        [XmlElement(DataType = "date")]
        public System.DateTime FnlColltnDt { get; set; }


        [XmlIgnore()]
        public bool FnlColltnDtSpecified { get; set; }


        public Frequency6Code Frqcy { get; set; }


        [XmlIgnore()]
        public bool FrqcySpecified { get; set; }
    }


}

