using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class StructuredRegulatoryReporting2
    {


        public string Cd { get; set; }

        public CurrencyAndAmount Amt { get; set; }

        public string Inf { get; set; }

    }

}
