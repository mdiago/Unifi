using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{

    public partial class CashAccountType2
    {


        [XmlElement("Cd", typeof(CashAccountTypeCode))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }

}
