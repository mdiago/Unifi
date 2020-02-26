using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class Authorisation1Choice
    {

        [XmlElement("Cd", typeof(Authorisation1Code))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }

}
