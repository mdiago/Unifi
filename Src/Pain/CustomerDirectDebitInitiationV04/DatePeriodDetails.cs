using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV04
{
    public partial class DatePeriodDetails
    {
        [XmlElement(DataType = "date")]
        public System.DateTime FrDt { get; set; }


        [XmlElement(DataType = "date")]
        public System.DateTime ToDt { get; set; }
    }


}

