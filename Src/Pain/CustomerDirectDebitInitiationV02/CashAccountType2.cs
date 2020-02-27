using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class CashAccountType2
    {


        [XmlElement("Cd", typeof(CashAccountTypeCode))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }


}

