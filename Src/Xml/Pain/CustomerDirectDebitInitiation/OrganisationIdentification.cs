/*
    This file is part of the Unifi (R) project.
    Copyright (c) 2020 Irene Solutions SL
    Authors: Irene Solutions SL.

    This program is free software; you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License version 3
    as published by the Free Software Foundation with the addition of the
    following permission added to Section 15 as permitted in Section 7(a):
    FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
    IRENE SOLUTIONS SL. IRENE SOLUTIONS SL DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
    OF THIRD PARTY RIGHTS
    
    This program is distributed in the hope that it will be useful, but
    WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
    or FITNESS FOR A PARTICULAR PURPOSE.
    See the GNU Affero General Public License for more details.
    You should have received a copy of the GNU Affero General Public License
    along with this program; if not, see http://www.gnu.org/licenses or write to
    the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
    Boston, MA, 02110-1301 USA, or download the license from the following URL:
        http://www.irenesolutions.com/terms-of-use.pdf
    
    The interactive user interfaces in modified source and object code versions
    of this program must display Appropriate Legal Notices, as required under
    Section 5 of the GNU Affero General Public License.
    
    You can be released from the requirements of the license by purchasing
    a commercial license. Buying such a license is mandatory as soon as you
    develop commercial activities involving the Unifi software without
    disclosing the source code of your own applications.
    These activities include: offering paid services to customers as an ASP,
    serving Unifi services on the fly in a web application, shipping Unifi
    with a closed source product.
    
    For more information, please contact Irene Solutions SL. at this
    address: info@irenesolutions.com
 */

using System;
using System.Xml.Serialization;

namespace Unifi.Xml.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// Conjuntos de elementos para identificar un nombre del esquema de identificación de la organización.
    /// </summary>
    public class OrganisationIdentification
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
