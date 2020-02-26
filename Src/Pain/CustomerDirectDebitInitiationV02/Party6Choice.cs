using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class Party6Choice
    {


        [XmlElement("OrgId", typeof(OrganisationIdentification4))]
        [XmlElement("PrvtId", typeof(PersonIdentification5))]
        public object Item { get; set; }

    }


}
