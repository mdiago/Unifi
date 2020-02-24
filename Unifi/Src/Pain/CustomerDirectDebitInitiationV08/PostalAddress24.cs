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
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [Serializable()]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.08")]
    public partial class PostalAddress24
    {

        /// <summary>
        /// AddressType.
        /// </summary>
        public AddressType3Choice AdrTp { get; set; }

        /// <summary>
        /// Department.
        /// </summary>
        public string Dept { get; set; }

        /// <summary>
        /// SubDepartment.
        /// </summary>
        public string SubDept { get; set; }

        /// <summary>
        /// StreetName. Name of a street or thoroughfare. Max70Text.
        /// </summary> 
        public string StrtNm { get; set; }

        /// <summary>
        /// BuildingNumber. Number that identifies the position of a building on a street.
        /// Max16Text.
        /// </summary>
        public string BldgNb { get; set; }

        /// <summary>
        /// BuildingName. Name of the building or house.
        /// </summary>
        public string BldgNm { get; set; }

        /// <summary>
        /// Floor or storey within a building.
        /// </summary>
        public string Flr { get; set; }

        /// <summary>
        /// Numbered box in a post office, assigned to a person or organisation, where letters are kept
        /// until called for. Max16Text.
        /// </summary>
        public string PstBx { get; set; }

        /// <summary>
        /// Building room number.
        /// </summary>
        public string Room { get; set; }

        /// <summary>
        /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to
        /// assist the sorting of mail. Max16Text.
        /// </summary>
        public string PstCd { get; set; }

        /// <summary>
        /// Name of a built-up area, with defined boundaries, and a local government. Max35Text.
        /// </summary>
        public string TwnNm { get; set; }

        /// <summary>
        /// Specific location name within the town. Max35Text.
        /// </summary>
        public string TwnLctnNm { get; set; }

        /// <summary>
        /// Identifies a subdivision within a country sub-division. Max35Text.
        /// </summary>
        public string DstrctNm { get; set; }

        /// <summary>
        /// Identifies a subdivision of a country such as state, region, county. Max35Text.
        /// </summary>
        public string CtrySubDvsn { get; set; }

        /// <summary>
        /// Country. Nation with its own government. ISO 3166 Alpha-2 code.
        /// </summary>
        public string Ctry { get; set; }

        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services,
        /// presented in free format text. Max70Text
        /// </summary>
        [XmlElement("AdrLine")]
        public string[] AdrLine { get; set; }

    }
}
