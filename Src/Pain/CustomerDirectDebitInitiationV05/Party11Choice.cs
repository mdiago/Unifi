using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV05
{
    public partial class Party11Choice
    {
        [XmlElement("OrgId", typeof(OrganisationIdentification))]
        [XmlElement("PrvtId", typeof(PersonIdentification))]
        public object Item { get; set; }

    }



}

