using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{
    [Serializable()]
    public partial class Authorisation1Choice
    {

        [XmlElement("Cd", typeof(AuthorisationCode))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }

}
