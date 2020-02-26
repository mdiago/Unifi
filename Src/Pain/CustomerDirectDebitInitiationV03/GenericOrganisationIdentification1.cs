using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03")]
    public partial class GenericOrganisationIdentification1
    {

        public string Id { get; set; }

        public OrganisationIdentificationSchemeName1Choice SchmeNm { get; set; }

        public string Issr { get; set; }

    }



}

