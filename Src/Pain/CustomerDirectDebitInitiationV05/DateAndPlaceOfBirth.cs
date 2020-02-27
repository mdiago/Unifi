using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV05
{
    public partial class DateAndPlaceOfBirth
    {
        [XmlElement(DataType = "date")]
        public DateTime BirthDt { get; set; }

        public string PrvcOfBirth { get; set; }

        public string CityOfBirth { get; set; }

        public string CtryOfBirth { get; set; }

    }



}

