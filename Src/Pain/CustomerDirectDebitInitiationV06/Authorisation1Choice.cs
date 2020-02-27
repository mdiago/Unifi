using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV06
{
    public partial class Authorisation1Choice
    {


        
        [XmlElement("Cd", typeof(Authorisation1Code))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }



}

