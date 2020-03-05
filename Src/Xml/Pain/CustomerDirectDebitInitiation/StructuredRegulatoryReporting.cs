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
    /// Información necesaria debido a requisitos reglamentarios y legales.
    /// </summary>
    [Serializable()]
    public class StructuredRegulatoryReporting
    {

        /// <summary>
        /// Especifica el tipo de información suministrada en los detalles de informes reglamentarios.
        /// </summary>
        public string Tp { get; set; }

        /// <summary>
        /// Fecha relacionada con el tipo especificado de detalles de informes reglamentarios.
        /// </summary>
        [XmlElement(DataType = "date")]
        public DateTime Dt { get; set; }

        [XmlIgnore()]
        public bool DtSpecified { get; set; }

        /// <summary>
        /// País relacionado con el tipo especificado de detalles de informes reglamentarios.
        /// </summary>
        public string Ctry { get; set; }

        /// <summary>
        /// Especifica la naturaleza, el propósito y el motivo de la transacción que se
        /// informará para los requisitos reglamentarios y legales en forma codificada.
        /// </summary>
        public string Cd { get; set; }

        /// <summary>
        /// Cantidad de dinero que se informará para los requisitos reglamentarios y legales.
        /// </summary>
        public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

        /// <summary>
        ///  Detalles adicionales que satisfacen los requisitos reglamentarios nacionales específicos.
        /// </summary>
        [XmlElement("Inf", typeof(string), Namespace = Namespaces.V01)]
        [XmlElement("Inf", typeof(string[]), Namespace = Namespaces.V08)]
        public virtual object Inf { get; set; }

    }
}
