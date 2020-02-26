using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class Authorisation1Choice
    {

        [XmlElement("Cd", typeof(Authorisation1Code))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }



}

