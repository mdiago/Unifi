using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
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
