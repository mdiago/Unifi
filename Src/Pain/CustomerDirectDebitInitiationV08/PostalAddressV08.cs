using System;
using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV08
{

    /// <summary>
    /// Representa una dirección postal.
    /// </summary>
    [Serializable()]
    public class PostalAddressV08 : PostalAddress
    {

        /// <summary>
        /// Tipo de dirección. Propieda válida de las versiones
        /// 1 a la 7. Para la versión 8 utilizar una instancia de
        /// la clase AddressTypeChoice.
        /// </summary>
        [XmlElement("AdrTp", typeof(AddressTypeChoice))]
        public override object AdrTp { get; set; }

    }
}
