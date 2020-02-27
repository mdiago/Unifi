using System;
using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV06
{
    public partial class MandateRelatedInformation10
    {
        
        
        public string MndtId { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime DtOfSgntr { get; set; }

        [XmlIgnore()]
        public bool DtOfSgntrSpecified { get; set; }

        public bool AmdmntInd { get; set; }

        [XmlIgnore()]
        public bool AmdmntIndSpecified { get; set; }

        public AmendmentInformationDetails10 AmdmntInfDtls { get; set; }

        public string ElctrncSgntr { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime FrstColltnDt { get; set; }

        [XmlIgnore()]
        public bool FrstColltnDtSpecified { get; set; }


        [XmlElement(DataType = "date")]
        public DateTime FnlColltnDt { get; set; }

        [XmlIgnore()]
        public bool FnlColltnDtSpecified { get; set; }

        public Frequency21Choice Frqcy { get; set; }

        public CdOrPrtryTypeChoice Rsn { get; set; }

    }



}

