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

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// Proporciona más detalles relacionados con un mandato de débito directo firmado entre el acreedor y el deudor.
    /// </summary>
    [Serializable()]
    public class MandateRelatedInformation
    {

        /// <summary>
        /// Identificación única, según lo asignado por el acreedor, para identificar inequívocamente el mandato.
        /// </summary>
        public string MndtId { get; set; }

        /// <summary>
        /// Fecha en que el deudor ha firmado el mandato de domiciliación bancaria.
        /// </summary>
        [XmlElement(DataType = "date")]
        public DateTime DtOfSgntr { get; set; }

        [XmlIgnore()]
        public bool DtOfSgntrSpecified { get; set; }

        /// <summary>
        /// Indicador que notifica si el mandato subyacente se modifica o no.
        /// </summary>
        public bool AmdmntInd { get; set; }

        [XmlIgnore()]
        public bool AmdmntIndSpecified { get; set; }

        /// <summary>
        /// Indicador que notifica si el mandato subyacente se modifica o no.
        /// </summary>
        public AmendmentInformationDetails AmdmntInfDtls { get; set; }

        /// <summary>
        /// Indicador que notifica si el mandato subyacente se modifica o no.
        /// </summary>
        public string ElctrncSgntr { get; set; }

        /// <summary>
        ///  Fecha de la primera cobranza de un débito directo según el mandato.
        /// </summary>
        [XmlElement(DataType = "date")]
        public DateTime FrstColltnDt { get; set; }

        [XmlIgnore()]
        public bool FrstColltnDtSpecified { get; set; }

        /// <summary>
        /// Fecha de la primera cobranza de un débito directo según el mandato.
        /// </summary>
        [XmlElement(DataType = "date")]
        public DateTime FnlColltnDt { get; set; }

        [XmlIgnore()]
        public bool FnlColltnDtSpecified { get; set; }

        /// <summary>
        /// Regularidad con la que se deben crear y procesar las instrucciones de débito directo.
        /// </summary>
        [XmlElement("Frqcy", typeof(FrequencyCode), Namespace = Namespaces.V02)]
        [XmlElement("Frqcy", typeof(FrequencyChoice), Namespace = Namespaces.V08)]
        public virtual object Frqcy { get; set; }

        /// <summary>
        /// Motivo del mandato de débito directo para permitir al usuario distinguir
        /// entre diferentes mandatos para el mismo acreedor.
        /// </summary>
        public CdOrPrtryTypeChoice Rsn { get; set; }

        /// <summary>
        /// Especifica el número de días que se debe rastrear la instrucción de débito directo.
        /// </summary>
        public string TrckgDays { get; set; }

    }
}
