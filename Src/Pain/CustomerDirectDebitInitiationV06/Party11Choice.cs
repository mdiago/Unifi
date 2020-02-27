using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV06
{
    public partial class Party11Choice
    {

        
        [XmlElement("OrgId", typeof(OrganisationIdentification))]
        [XmlElement("PrvtId", typeof(PersonIdentification5))]
        public object Item { get; set; }

    }



}

