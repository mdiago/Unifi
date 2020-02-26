﻿using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
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
