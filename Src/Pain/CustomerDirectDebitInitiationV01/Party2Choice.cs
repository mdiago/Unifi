using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01 
{
  
    public partial class Party2Choice
    {


        [XmlElement("OrgId", typeof(OrganisationIdentification2))]
        [XmlElement("PrvtId", typeof(PersonIdentification3))]
        public object[] Items { get; set; }

    }

}

