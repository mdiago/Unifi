using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class GenericPersonIdentification1
    {

        public string Id { get; set; }

        public PersonIdentificationSchemeName1Choice SchmeNm { get; set; }

        public string Issr { get; set; }

    }

}
