using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{
    /// <summary>
    /// Sólo válido versión 1.
    /// </summary>
    public partial class TaxType
    {

        public string CtgyDesc { get; set; }

        public decimal Rate { get; set; }

        [XmlIgnore()]
        public bool RateSpecified { get; set; }

        public ActiveOrHistoricCurrencyAndAmount TaxblBaseAmt { get; set; }

        public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

    }

}
