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
    /// Proporciona más detalles sobre la lista de elementos del mandato
    /// de débito directo que se han modificado cuando se ha establecido
    /// el indicador de enmienda.
    /// </summary>
    [Serializable()]
    public class AmendmentInformationDetails
    {

        /// <summary>
        /// Identificación única, según lo asignado por el acreedor,
        /// para identificar inequívocamente el mandato original.
        /// </summary>
        public string OrgnlMndtId { get; set; }

        /// <summary>
        /// Identificación original del esquema de acreedor que ha sido modificado.
        /// </summary>
        public PartyIdentification OrgnlCdtrSchmeId { get; set; }

        /// <summary>
        /// Agente deudor original que ha sido modificado.
        /// </summary>
        public BranchAndFinancialInstitutionIdentification OrgnlCdtrAgt { get; set; }

        /// <summary>
        ///  Cuenta de agente acreedor original que ha sido modificada.
        /// </summary>
        public CashAccount OrgnlCdtrAgtAcct { get; set; }

        /// <summary>
        /// Deudor original que ha sido modificado.
        /// </summary>
        public PartyIdentification OrgnlDbtr { get; set; }

        /// <summary>
        /// Cuenta deudor original que ha sido modificada.
        /// </summary>
        public CashAccount OrgnlDbtrAcct { get; set; }

        /// <summary>
        /// Agente deudor original que ha sido modificado.
        /// </summary>
        public BranchAndFinancialInstitutionIdentification OrgnlDbtrAgt { get; set; }

        /// <summary>
        /// Cuenta original del agente deudor que ha sido modificada.
        /// </summary>
        public CashAccount OrgnlDbtrAgtAcct { get; set; }

        /// <summary>
        /// Fecha de recolección final original que ha sido modificada.
        /// </summary>
        [XmlElement(DataType = "date")]
        public DateTime OrgnlFnlColltnDt { get; set; }

        /// <summary>
        /// True si OrgnlFnlColltnDt especificado.
        /// </summary>
        [XmlIgnore()]
        public bool OrgnlFnlColltnDtSpecified { get; set; }

        /// <summary>
        /// Frecuencia original que ha sido modificada.
        /// </summary>
        [XmlElement("OrgnlFrqcy", typeof(FrequencyCode), Namespace = Namespaces.V02)]
        [XmlElement("OrgnlFrqcy", typeof(FrequencyChoice), Namespace = Namespaces.V08)]
        public virtual object OrgnlFrqcy { get; set; }

        /// <summary>
        /// True si OrgnlFrqcy especificado.
        /// </summary>
        [XmlIgnore()]
        public bool OrgnlFrqcySpecified { get; set; }

    }

}
