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

using System.Xml.Serialization;

namespace Unifi.Xml.Pain.CustomerDirectDebitInitiation
{
    public class ContactDetails
    {

        /// <summary>
        /// NamePrefix. Specifies the terms used to formally address a person.
        /// </summary>
        public NamePrefixCode NmPrfx { get; set; }

        /// <summary>
        /// True id NmPrfx specified.
        /// </summary>
        [XmlIgnore()]
        public bool NmPrfxSpecified { get; set; }

        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        public string Nm { get; set; }

        /// <summary>
        /// Collection of information that identifies a phone number, as defined by telecom services.
        /// </summary>
        public string PhneNb { get; set; }

        /// <summary>
        /// Collection of information that identifies a mobile phone number, as defined by telecom services.
        /// </summary>
        public string MobNb { get; set; }

        /// <summary>
        /// Collection of information that identifies a FAX number, as defined by telecom services.
        /// </summary>
        public string FaxNb { get; set; }

        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        public string EmailAdr { get; set; }

        /// <summary>
        /// Otros datos de contacto
        /// </summary>
        public virtual object Othr { get; set; }

    }

}
