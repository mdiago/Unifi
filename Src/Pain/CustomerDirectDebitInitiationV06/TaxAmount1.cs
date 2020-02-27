using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV06
{
    public partial class TaxAmount1
    {

        
        public decimal Rate { get; set; }

        [XmlIgnore()]
        public bool RateSpecified { get; set; }

        public ActiveOrHistoricCurrencyAndAmount TaxblBaseAmt { get; set; }

        public ActiveOrHistoricCurrencyAndAmount TtlAmt { get; set; }

        [XmlElement("Dtls")]
        public TaxRecordDetails1[] Dtls { get; set; }

    }



}

