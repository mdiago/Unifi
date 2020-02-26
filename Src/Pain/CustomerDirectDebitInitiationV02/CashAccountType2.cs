using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class CashAccountType2
    {


        [XmlElement("Cd", typeof(CashAccountType4Code))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }


}

