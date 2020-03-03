using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV05
{
    public partial class Frequency21Choice
    {
        [XmlElement("Prd", typeof(FrequencyPeriod1))]
        [XmlElement("Tp", typeof(FrequencyCode))]
        public object Item { get; set; }

    }



}

