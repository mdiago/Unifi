using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{

    public partial class OrganisationIdentification2
    {


        public string BIC { get; set; }

        public string IBEI { get; set; }

        public string BEI { get; set; }


        public string EANGLN { get; set; }


        public string USCHU { get; set; }


        public string DUNS { get; set; }


        public string BkPtyId { get; set; }


        public string TaxIdNb { get; set; }


        public GenericIdentification3 PrtryId { get; set; }

    }


}
