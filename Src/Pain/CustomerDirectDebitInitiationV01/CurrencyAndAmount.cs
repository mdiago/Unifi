using System.Xml.Serialization;
using System;
using Unifi.Pain;


namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class CurrencyAndAmount
    {


        [XmlAttribute()]
        public string Ccy { get; set; }


        [XmlText()]
        public decimal Value { get; set; }

    }
}
