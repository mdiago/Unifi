using System;
using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    public partial class Garnishment1
    {
        
        public GarnishmentType1 Tp { get; set; }

        public PartyIdentification Grnshee { get; set; }

        public PartyIdentification GrnshmtAdmstr { get; set; }

        public string RefNb { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime Dt { get; set; }

        [XmlIgnore()]
        public bool DtSpecified { get; set; }

        public ActiveOrHistoricCurrencyAndAmount RmtdAmt { get; set; }

        public bool FmlyMdclInsrncInd { get; set; }

        [XmlIgnore()]
        public bool FmlyMdclInsrncIndSpecified { get; set; }

        public bool MplyeeTermntnInd { get; set; }

        [XmlIgnore()]
        public bool MplyeeTermntnIndSpecified { get; set; }

    }


}

