using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03")]
    public partial class OrganisationIdentification8
    {

        public string AnyBIC { get; set; }

        [XmlElement("Othr")]
        public GenericOrganisationIdentification1[] Othr { get; set; }

    }



}

