using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    public partial class Frequency36Choice
    {

        
        [XmlElement("Prd", typeof(FrequencyPeriod1))]
        [XmlElement("PtInTm", typeof(FrequencyAndMoment1))]
        [XmlElement("Tp", typeof(Frequency6Code))]
        public object Item { get; set; }

    }


}

