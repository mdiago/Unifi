using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class PartyIdentification8
    {


        public string Nm { get; set; }


        public PostalAddress1 PstlAdr { get; set; }


        public Party2Choice Id { get; set; }


        public string CtryOfRes { get; set; }

    }
}
