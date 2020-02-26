using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class PartyIdentification32
    {

        public string Nm { get; set; }

        public PostalAddress6 PstlAdr { get; set; }

        public Party6Choice Id { get; set; }

        public string CtryOfRes { get; set; }

        public ContactDetails2 CtctDtls { get; set; }

    }

}
