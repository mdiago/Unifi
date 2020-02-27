using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV04
{
    public partial class DateAndPlaceOfBirth
    {


        [XmlElement(DataType = "date")]
        public System.DateTime BirthDt { get; set; }


        public string PrvcOfBirth { get; set; }


        public string CityOfBirth { get; set; }


        public string CtryOfBirth { get; set; }

    }


}

