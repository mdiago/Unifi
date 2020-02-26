using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{

    public partial class CashAccountType2
    {


        [XmlElement("Cd", typeof(CashAccountType4Code))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }

}
