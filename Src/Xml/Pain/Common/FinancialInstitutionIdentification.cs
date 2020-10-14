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

namespace Unifi.Xml.Pain.Common
{

    /// <summary>
    /// Especifica los detalles para identificar una institución financiera.
    /// </summary>
    [Serializable()]
    public class FinancialInstitutionIdentification
    {

        /// <summary>
        /// Unicamente válido en la versión 1.
        /// </summary>
        [XmlElement("CmbndId", typeof(FinancialInstitutionIdentification))]
        [XmlElement("NmAndAdr", typeof(NameAndAddress))]
        [XmlElement("PrtryId", typeof(GenericIdentification))]
        public object Item { get; set; }

        /// <summary>
        /// Sólo válido en la versión 2. Código asignado a una institución 
        /// financiera por la Autoridad de Registro ISO 9362 como se describe
        /// en ISO 9362 "Banca - Mensajes de telecomunicaciones bancarias - 
        /// Código de identificación comercial (BIC)".
        /// </summary>
        public string BIC { get; set; } 

        /// <summary>
        /// A partir de la versión 3. Código asignado a una institución 
        /// financiera por la Autoridad de Registro ISO 9362 como se describe 
        /// en ISO 9362 "Banca - Mensajes de telecomunicaciones bancarias - 
        /// Código de identificación comercial (BIC)".
        /// </summary>
        public string BICFI { get; set; }

        /// <summary>
        /// A partir de la versión 8. Identificador de la entidad jurídica de la institución financiera.
        /// </summary>
        public string LEI { get; set; }


        /// <summary>
        /// Información utilizada para identificar a un miembro dentro de un sistema de compensación.
        /// </summary>
        public ClearingSystemMemberIdentification ClrSysMmbId { get; set; } 

        /// <summary>
        /// Nombre por el que se conoce un agente y que generalmente se usa para identificar a ese agente.
        /// </summary>
        public string Nm { get; set; }

        /// <summary>
        /// Información que localiza e identifica una dirección específica, según lo definido por los servicios postales.
        /// </summary>
        [XmlElement("PstlAdr", typeof(PostalAddress))]
        public virtual object PstlAdr { get; set; }

        /// <summary>
        /// Identificación única de un agente, según lo asignado por una institución,
        /// utilizando un esquema de identificación.
        /// </summary>
        public GenericIdentificationCdOrPrtry Othr { get; set; }

    }


}

