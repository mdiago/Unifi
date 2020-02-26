using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class GenericOrganisationIdentification1
    {

        public string Id { get; set; }

        public OrganisationIdentificationSchemeName1Choice SchmeNm { get; set; }


        public string Issr { get; set; }

    }

}
