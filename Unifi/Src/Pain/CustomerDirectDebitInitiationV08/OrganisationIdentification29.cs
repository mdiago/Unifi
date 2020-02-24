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

namespace Unifi.Pain.CustomerDirectDebitInitiationV08
{

    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    [Serializable()]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.08")]
    public partial class OrganisationIdentification29
    {

        /// <summary>
        /// Only a valid Business identifier code is allowed. Business identifier codes for financial or nonfinancial
        /// institutions are registered and published by the ISO 9362 Registration Authority in the ISO
        /// directory of BICs, and consists of eight(8) or eleven(11) contiguous characters.
        /// </summary>
        public string AnyBIC { get; set; }

        /// <summary>
        /// Legal entity identification as an alternate identification for a party.
        /// </summary>
        public string LEI { get; set; }

        /// <summary>
        /// Unique identification of an organisation, as assigned by an institution, using an identification
        /// scheme.
        /// </summary>
        [XmlElement("Othr")]
        public GenericOrganisationIdentification1[] Othr { get; set; }

    }
}
