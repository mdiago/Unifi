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

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{

    /// <summary>
    /// Set of elements used to define the tax record.
    /// </summary>
    [Serializable()]
    [XmlType(Namespace = AaNamespaces.Root)]
    public class TaxRecord2
    {

        /// <summary>
        /// Type. High level code to identify the type of tax details. Max35Text.
        /// </summary>
        public string Tp { get; set; }

        /// <summary>
        /// Category. Specifies the tax code as published by the tax authority. Max35Text.
        /// </summary>
        public string Ctgy { get; set; }

        /// <summary>
        /// CategoryDetails. Provides further details of the category tax code. Max35Text.
        /// </summary>
        public string CtgyDtls { get; set; }

        /// <summary>
        /// Code provided by local authority to identify the status of the party that has drawn up the
        /// settlement document. Max35Text.
        /// </summary>
        public string DebtorStatus { get; set; }

        /// <summary>
        /// CertificateIdentification. Identification number of the tax report as assigned by 
        /// the taxing authority. Max35Text.
        /// </summary>
        public string CertId { get; set; }

        /// <summary>
        /// FormsCode. Identifies, in a coded form, on which template the tax report is 
        /// to be provided. Max35Text.
        /// </summary>
        public string FrmsCd { get; set; }

        /// <summary>
        /// Period. Set of elements used to provide details on the period of time related to the tax payment.
        /// </summary>
        public TaxPeriod2 Prd { get; set; }

        /// <summary>
        /// Set of elements used to provide information on the amount of the tax record.
        /// </summary>
        public TaxAmount2 TaxAmt { get; set; }

        /// <summary>
        /// AdditionalInformation. Further details of the tax record. Max140Text.
        /// </summary>
        public string AddtlInf { get; set; }

    }

}
