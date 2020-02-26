using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class OrganisationIdentification4
    {

        public string BICOrBEI { get; set; }

        [XmlElement("Othr")]
        public GenericOrganisationIdentification1[] Othr { get; set; }

    }

}
