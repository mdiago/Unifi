using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class PersonIdentification5
    {
    
        public DateAndPlaceOfBirth DtAndPlcOfBirth { get; set; }

        [XmlElement("Othr")]
        public GenericPersonIdentification1[] Othr { get; set; }

    }



}

