using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03")]
    public partial class CashAccount24
    {

        public AccountIdentificationChoice Id { get; set; }

        public CdOrPrtryTypeChoice Tp { get; set; }

        public string Ccy { get; set; }

        public string Nm { get; set; }

    }



}

