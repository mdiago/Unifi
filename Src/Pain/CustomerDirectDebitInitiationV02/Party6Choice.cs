using System;
using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class Party6Choice
    {


        [XmlElement("OrgId", typeof(OrganisationIdentification))]
        [XmlElement("PrvtId", typeof(PersonIdentification))]
        public object Item { get; set; }

    }


}
