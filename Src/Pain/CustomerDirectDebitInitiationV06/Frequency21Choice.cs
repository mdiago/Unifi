using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV06
{
    public partial class Frequency21Choice
    {

        
        [XmlElement("Prd", typeof(FrequencyPeriod1))]
        [XmlElement("Tp", typeof(Frequency6Code))]
        public object Item { get; set; }

    }



}

