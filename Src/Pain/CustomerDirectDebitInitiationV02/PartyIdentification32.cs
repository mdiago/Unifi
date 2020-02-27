using System;
using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class PartyIdentification32
    {

        public string Nm { get; set; }

        public PostalAddress PstlAdr { get; set; }

        public Party6Choice Id { get; set; }

        public string CtryOfRes { get; set; }

        public ContactDetails CtctDtls { get; set; }

    }

}
