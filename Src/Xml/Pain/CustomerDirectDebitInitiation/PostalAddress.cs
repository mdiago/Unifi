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
    /// Representa una dirección postal.
    /// </summary>
    [Serializable()]
    public class PostalAddress
    {

        /// <summary>
        /// Tipo de dirección. Propieda válida de las versiones
        /// 1 a la 7. Para la versión 8 utilizar una instancia de
        /// la clase PostalAddressV08.
        /// </summary>
        [XmlElement("AdrTp", typeof(AddressTypeCode), Namespace = Namespaces.V02)]
        [XmlElement("AdrTp", typeof(AddressTypeChoice), Namespace = Namespaces.V08)]
        public virtual object AdrTp { get; set; }

        /// <summary>
        /// True si AdrTp especificado.
        /// </summary>
        [XmlIgnore()]
        public bool AdrTpCodeSpecified { get; set; }
  

        /// <summary>
        /// Departmento. Valor válido a partir de la
        /// versión 2.
        /// </summary>
        public string Dept { get; set; }

        /// <summary>
        /// SubDepartmento. Valor válido a partir de la versión 2.
        /// </summary>
        public string SubDept { get; set; }

        /// <summary>
        /// StreetName. Nombre de la vía: calle, avenida, plaza...
        /// Max70Text. Todas las versiones.
        /// </summary> 
        public string StrtNm { get; set; }

        /// <summary>
        /// BuildingNumber. Número que identifica la posición 
        /// de una construcción en una vía.
        /// Max16Text.  Todas las versiones.
        /// </summary>
        public string BldgNb { get; set; }

        /// <summary>
        /// BuildingName. Nombre del edificio o casa. Válido a partir de la versión 8.
        /// </summary>
        public string BldgNm { get; set; }

        /// <summary>
        /// Piso de un edificio o casa. Válido a partir de la versión 8.
        /// </summary>
        public string Flr { get; set; }

        /// <summary>
        /// Número de apartado de correos en una oficna postal asignado a una
        /// persona u organización dónde se deposita la correspondencia para la misma.
        /// Max16Text.  Válido a partir de la versión 8.
        /// </summary>
        public string PstBx { get; set; }

        /// <summary>
        /// Número de viviedna, oficna, entresuelo, local...  Válido a partir de la versión 8.
        /// </summary>
        public string Room { get; set; }

        /// <summary>
        /// Código postal. Max16Text.  Todas las versiones.
        /// </summary>
        public string PstCd { get; set; }

        /// <summary>
        /// Nombre ciudad. Max35Text. Todas las versiones.
        /// </summary>
        public string TwnNm { get; set; }

        /// <summary>
        /// Nombre distrito o barrio de una ciudad. Max35Text.  Válido a partir de la versión 8.
        /// </summary>
        public string TwnLctnNm { get; set; }

        /// <summary>
        /// Identifica una subdivisión de una subdivisión de país.
        /// Por ejemplo (España > Comunidad Valencia > Castellón).
        /// Max35Text.  Válido a partir de la versión 8.
        /// </summary>
        public string DstrctNm { get; set; }

        /// <summary>
        /// Subdivisión de un país (España > Comunidad Valenciana) . Max35Text. Todas las versiones.
        /// </summary>
        public string CtrySubDvsn { get; set; }

        /// <summary>
        /// Código pais ISO 3166 Alpha-2. Todas las versiones.
        /// </summary>
        public string Ctry { get; set; }

        /// <summary>
        /// Colección de líneas con iformación para localizar e identificar
        /// una dirección especifica, atendiendo a las especificaciones establecidas
        /// por los servicios postales. Max70Text
        /// </summary>
        [XmlElement("AdrLine")]
        public string[] AdrLine { get; set; }

    }
}
