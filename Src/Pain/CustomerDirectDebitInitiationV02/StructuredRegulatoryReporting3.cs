using System;
using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class StructuredRegulatoryReporting3
    {

        public string Tp { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime Dt { get; set; }

        [XmlIgnore()]
        public bool DtSpecified { get; set; }

        public string Ctry { get; set; }

        public string Cd { get; set; }

        public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

        [XmlElement("Inf")]
        public string[] Inf { get; set; }

    }


}

