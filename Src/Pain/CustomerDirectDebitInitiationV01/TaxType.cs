using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class TaxType
    {

        public string CtgyDesc { get; set; }

        public decimal Rate { get; set; }

        [XmlIgnore()]
        public bool RateSpecified { get; set; }

        public CurrencyAndAmount TaxblBaseAmt { get; set; }

        public CurrencyAndAmount Amt { get; set; }

    }

}
