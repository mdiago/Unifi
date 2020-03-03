using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    public partial class Frequency36Choice
    {

        
        [XmlElement("Prd", typeof(FrequencyPeriod1))]
        [XmlElement("PtInTm", typeof(FrequencyAndMoment1))]
        [XmlElement("Tp", typeof(FrequencyCode))]
        public object Item { get; set; }

    }


}

