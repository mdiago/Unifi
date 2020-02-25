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
    /// Specifies the identification of a person or an organisation.
    /// </summary>
    [Serializable()]
    [XmlType(Namespace = AaNamespaces.Root)]
    public class PartyIdentification135
    {

        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        public string Nm { get; set; }

        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        public PostalAddress24 PstlAdr { get; set; }

        /// <summary>
        /// Unique and unambiguous identification of a party.
        /// </summary>
        public Party38Choice Id { get; set; }

        /// <summary>
        /// CountryOfResidence. Country in which a person resides (the place of a person's home). 
        /// In the case of a company, it is the country from which the affairs of that 
        /// company are directed.
        /// </summary>
        public string CtryOfRes { get; set; }

        /// <summary>
        /// ContactDetails. Set of elements used to indicate how to contact the party.
        /// </summary>
        public Contact4 CtctDtls { get; set; }

        /// <summary>
        /// Representación textual de la instancia.
        /// </summary>
        /// <returns>Representación textual de la instancia.</returns>
        public override string ToString()
        {
            return $"{Nm}";
        }

    }

}
