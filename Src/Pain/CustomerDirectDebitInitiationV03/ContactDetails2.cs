using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class ContactDetails2
    {

   
        public NamePrefix1Code NmPrfx { get; set; }

        [XmlIgnore()]
        public bool NmPrfxSpecified { get; set; }

        public string Nm { get; set; }

        public string PhneNb { get; set; }

        public string MobNb { get; set; }

        public string FaxNb { get; set; }

        public string EmailAdr { get; set; }

        public string Othr { get; set; }

    }



}

