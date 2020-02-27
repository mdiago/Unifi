using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{
    public partial class ContactDetails
    {

        /// <summary>
        /// NamePrefix. Specifies the terms used to formally address a person.
        /// </summary>
        public NamePrefixCode NmPrfx { get; set; }

        /// <summary>
        /// True id NmPrfx specified.
        /// </summary>
        [XmlIgnore()]
        public bool NmPrfxSpecified { get; set; }

        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        public string Nm { get; set; }

        /// <summary>
        /// Collection of information that identifies a phone number, as defined by telecom services.
        /// </summary>
        public string PhneNb { get; set; }

        /// <summary>
        /// Collection of information that identifies a mobile phone number, as defined by telecom services.
        /// </summary>
        public string MobNb { get; set; }

        /// <summary>
        /// Collection of information that identifies a FAX number, as defined by telecom services.
        /// </summary>
        public string FaxNb { get; set; }

        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        public string EmailAdr { get; set; }

        /// <summary>
        /// Otros datos de contacto
        /// </summary>
        public virtual object Othr { get; set; }

    }

}
