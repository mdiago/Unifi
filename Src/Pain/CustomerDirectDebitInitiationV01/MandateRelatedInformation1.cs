using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{

    public partial class MandateRelatedInformation1
    {


        public string MndtId { get; set; }


        [XmlElement(DataType = "date")]
        public DateTime DtOfSgntr { get; set; }


        [XmlIgnore()]
        public bool DtOfSgntrSpecified { get; set; }


        public bool AmdmntInd { get; set; }


        [XmlIgnore()]
        public bool AmdmntIndSpecified { get; set; }


        public AmendmentInformationDetails1 AmdmntInfDtls { get; set; }


        public string ElctrncSgntr { get; set; }


        [XmlElement(DataType = "date")]
        public DateTime FrstColltnDt { get; set; }



        [XmlIgnore()]
        public bool FrstColltnDtSpecified { get; set; }


        [XmlElement(DataType = "date")]
        public DateTime FnlColltnDt { get; set; }


        [XmlIgnore()]
        public bool FnlColltnDtSpecified { get; set; }

        public Frequency1Code Frqcy { get; set; }


        [XmlIgnore()]
        public bool FrqcySpecified { get; set; }

    }

}
