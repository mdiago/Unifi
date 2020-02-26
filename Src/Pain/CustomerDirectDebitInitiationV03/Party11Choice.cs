using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class Party11Choice
    {

    
        [XmlElement("OrgId", typeof(OrganisationIdentification8))]
        [XmlElement("PrvtId", typeof(PersonIdentification5))]
        public object Item { get; set; }

    }



}

