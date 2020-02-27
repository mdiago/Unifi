using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// Conjunto de elementos utilizados para identificar a una persona u organización.
    /// </summary>
    [Serializable()]
    public partial class PartyIdentification
    {

        /// <summary>
        /// Nombre con el que una parte es conocida,
        /// usado habitualmente para identificarla.
        /// </summary>
        public string Nm { get; set; }

        /// <summary>
        /// Información de la localización de una parte de acuerdo
        /// a lo establecido por los servicios postales.
        /// </summary>
        public PostalAddress PstlAdr { get; set; }

        /// <summary>
        /// Identificación unívoca de la organización o
        /// persona.
        /// </summary>
        public PartyChoice Id { get; set; }

        /// <summary>
        /// País de residencia.
        /// </summary>
        public string CtryOfRes { get; set; }

        /// <summary>
        /// A partir de la versión 2. Datos de contacto.
        /// </summary>
        public object CtctDtls { get; set; }

    }
}
