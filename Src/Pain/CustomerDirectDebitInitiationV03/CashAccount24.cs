using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.03")]
    public partial class CashAccount24
    {

        public AccountIdentification4Choice Id { get; set; }

        public CashAccountType2Choice Tp { get; set; }

        public string Ccy { get; set; }

        public string Nm { get; set; }

    }



}

