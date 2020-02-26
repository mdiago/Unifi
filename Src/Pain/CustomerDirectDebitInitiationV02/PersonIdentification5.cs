using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class PersonIdentification5
    {

        public DateAndPlaceOfBirth DtAndPlcOfBirth { get; set; }

        [XmlElement("Othr")]
        public GenericPersonIdentification1[] Othr { get; set; }

    }

}
