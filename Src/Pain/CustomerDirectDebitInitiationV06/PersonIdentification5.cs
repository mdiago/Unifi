using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV06
{
    public partial class PersonIdentification5
    {

        
        public DateAndPlaceOfBirth DtAndPlcOfBirth { get; set; }

        [XmlElement("Othr")]
        public GenericIdentificationCdOrPrtry[] Othr { get; set; }

    }



}

