using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    public partial class DateAndPlaceOfBirth
    {



        /// <summary>
        /// Date on which a person is born. ISODate.
        /// </summary>
        [XmlElement(DataType = "date")]
        public DateTime BirthDt { get; set; }

        /// <summary>
        /// Province where a person was born. Max35Text.
        /// </summary>
        public string PrvcOfBirth { get; set; }

        /// <summary>
        /// City where a person was born. Max35Text.
        /// </summary>
        public string CityOfBirth { get; set; }

        /// <summary>
        /// CountryOfBirth. Country where a person was born.
        /// </summary>
        public string CtryOfBirth { get; set; }

    }


}
