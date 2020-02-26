using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class ActiveOrHistoricCurrencyAndAmount
    {

        [XmlAttribute()]
        public string Ccy { get; set; }

        [XmlText()]
        public decimal Value { get; set; }

    }

}
