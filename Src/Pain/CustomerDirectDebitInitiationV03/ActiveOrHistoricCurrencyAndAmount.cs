using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class ActiveOrHistoricCurrencyAndAmount
    {

    
        [XmlAttribute()]
        public string Ccy { get; set; }

        [XmlText()]
        public decimal Value { get; set; }

    }



}

