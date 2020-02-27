using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// Conjuntos de elementos para identificar un nombre del esquema de identificación de la organización.
    /// </summary>
    public partial class OrganisationIdentification
    {


        /// <summary>
        /// Únicamente válido para la versión 1.
        /// Código asignado a una institución financiera por la Autoridad
        /// de Registro ISO 9362 como se describe en ISO 9362 "Banca - 
        /// Mensajes de telecomunicaciones bancarias - Código de
        /// identificación comercial (BIC)".
        /// </summary>
        [Obsolete("Utilizar únicamente en la versión 1.")]
        public string BIC { get; set; }

        /// <summary>
        /// Únicamente válido para la versión 1.
        /// Identificador de entidad comercial internacional para identificar
        /// de forma exclusiva entidades comerciales que desempeñan un
        /// papel en el ciclo de vida y los eventos relacionados con un
        /// instrumento financiero. (provisional - por confirmar).
        /// </summary>
        [Obsolete("Utilizar únicamente en la versión 1.")]
        public string IBEI { get; set; }

        /// <summary>
        /// Únicamente válido para la versión 1.
        /// Código asignado a una institución no financiera por la Autoridad
        /// de Registro ISO 9362 como se describe en ISO 9362
        /// "Banca - Mensajes de telecomunicaciones
        /// bancarias - Código de identificación comercial (BIC)".
        /// </summary>
        [Obsolete("Utilizar únicamente en la versión 1.")]
        public string BEI { get; set; }

        /// <summary>
        /// Únicamente válido para la versión 1.
        /// Número de ubicación global. Un número de referencia no
        /// significativo utilizado para identificar entidades
        /// jurídicas, entidades funcionales o entidades físicas de
        /// acuerdo con las reglas del esquema de numeración de la
        /// Asociación Europea de Numeración (EAN). El número se utiliza
        /// para recuperar información detallada que está vinculada a él.
        /// </summary>
        [Obsolete("Utilizar únicamente en la versión 1.")]
        public string EANGLN { get; set; }

        /// <summary>
        /// Únicamente válido para la versión 1.
        /// (Estados Unidos) Sistema de pagos interbancarios de la cámara de compensación
        /// (CHIPS) Identificación universal (UID): identifica las entidades que 
        /// poseen cuentas en las instituciones financieras participantes de CHIPS,
        /// a través de las cuales se efectúan los pagos de CHIPS. El UID de CHIPS es
        /// asignado por la Cámara de Compensación de Nueva York.
        /// </summary>
        [Obsolete("Utilizar únicamente en la versión 1.")]
        public string USCHU { get; set; }

        /// <summary>
        /// Únicamente válido para la versión 1.
        /// Sistema de numeración universal de datos. Un número de identificación único
        /// proporcionado por Dun & Bradstreet para identificar una organización.
        /// </summary>
        [Obsolete("Utilizar únicamente en la versión 1.")]
        public string DUNS { get; set; }

        /// <summary>
        /// Únicamente válido para la versión 1.
        /// Asignación única e inequívoca realizada por un banco específico
        /// para identificar una relación definida entre el banco y su cliente.
        /// </summary>
        [Obsolete("Utilizar únicamente en la versión 1.")]
        public string BkPtyId { get; set; }

        /// <summary>
        /// Únicamente válido para la versión 1.
        /// Númeo de identificación fiscal. Número asignado por una autoridad fiscal a una entidad.
        /// </summary>
        [Obsolete("Utilizar únicamente en la versión 1.")]
        public string TaxIdNb { get; set; }

        /// <summary>
        /// Únicamente válido para la versión 1.
        /// Identificador único e inequívoco para una organización que es asignada por una institución.
        /// </summary>
        [Obsolete("Utilizar únicamente en la versión 1.")]
        public GenericIdentification PrtryId { get; set; }

        /// <summary>
        /// A partir de la versión 2.
        /// </summary>
        [Obsolete("Utilizar únicamente en la versión 2.")]
        public string BICOrBEI { get; set; }

        /// <summary>
        /// A partir de la versión 3. Código de identificación comercial utilizado para identificar la organización.
        /// Sólo se admiten identificadores válidos. Los identificadores de negocio para entidades financieras
        /// y no financieras son registrados y publicados mediante la ISO 9362 en el directorio ISO de BICs,
        /// y consite en un código de 8 o 11 caracteres.
        /// </summary>
        public string AnyBIC { get; set; }

        /// <summary>
        /// A partir de la versión 8. Entidad legal como alternativa de identificación de organización.
        /// </summary>
        public string LEI { get; set; }

        /// <summary>
        /// A partir de la versión 2.	
        /// Identificación única de una organización, según lo asignado por una institución,
        /// utilizando un esquema de identificación.
        /// </summary>
        [XmlElement("Othr")]
        public GenericOrganisationIdentification[] Othr { get; set; }

    }


}
