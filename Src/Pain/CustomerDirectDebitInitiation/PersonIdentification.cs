using System.Xml.Serialization;
using System;
using Unifi.Pain;


namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// Identificador de persona.
    /// </summary>
    public partial class PersonIdentification
    {


        [XmlElement("AlnRegnNb", typeof(string))]
        [XmlElement("CstmrNb", typeof(string))]
        [XmlElement("DrvrsLicNb", typeof(string))]
        [XmlElement("IdntyCardNb", typeof(string))]
        [XmlElement("MplyrIdNb", typeof(string))]
        [XmlElement("OthrId", typeof(GenericIdentification))]
        [XmlElement("PsptNb", typeof(string))]
        [XmlElement("SclSctyNb", typeof(string))]
        [XmlElement("TaxIdNb", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public object Item { get; set; }


        [XmlIgnore()]
        public PersonIdentificationType ItemElementName { get; set; }

        /// <summary>
        /// Entidad que asigna el identificador.
        /// </summary>
        public string Issr { get; set; }

        /// <summary>
        /// A partir de la versión 2.
        /// </summary>
        public DateAndPlaceOfBirth DtAndPlcOfBirth { get; set; }

        /// <summary>
        ///  A partir de la versión 2.
        /// </summary>
        [XmlElement("Othr")]
        public GenericIdentificationCdOrPrtry[] Othr { get; set; }

    }


}
