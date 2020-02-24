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
    /// Provides remittance information about a payment made for tax-related purposes.
    /// Details about tax paid, or to be paid, to the government in accordance with the law, including
    /// pre-defined parameters such as thresholds and type of account.
    /// </summary>
    [Serializable()]
    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.08")]
    public partial class TaxInformation7
    {

        /// <summary>
        /// Creditor. Party on the credit side of the transaction to which the tax applies.
        /// </summary>
        public TaxParty1 Cdtr { get; set; }

        /// <summary>
        /// Identifies the party on the debit side of the transaction to which the tax applies.
        /// </summary>
        public TaxParty2 Dbtr { get; set; }

        /// <summary>
        /// UltimateDebtor. Ultimate party that owes an amount of money to the (ultimate) creditor, in this case, to the
        /// taxing authority.
        /// </summary>
        public TaxParty2 UltmtDbtr { get; set; }

        /// <summary>
        /// AdministrationZone. Territorial part of a country to which the tax payment is related. Max35Text.
        /// </summary>
        public string AdmstnZone { get; set; }

        /// <summary>
        /// ReferenceNumber. Tax reference information that is specific to a taxing agency. Max140Text.
        /// </summary>
        public string RefNb { get; set; }

        /// <summary>
        /// Method. Method used to indicate the underlying business or how the tax is paid. Max35Text.
        /// </summary>
        public string Mtd { get; set; }

        /// <summary>
        /// TotalTaxableBaseAmount. Total amount of money on which the tax is based.
        /// </summary>
        public ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt { get; set; }

        /// <summary>
        /// TotalTaxAmount. Total amount of money as result of the calculation of the tax.
        /// </summary>
        public ActiveOrHistoricCurrencyAndAmount TtlTaxAmt { get; set; }

        /// <summary>
        /// Date. Date by which tax is due.
        /// </summary>
        [XmlElement(DataType = "date")]
        public DateTime Dt { get; set; }

        /// <summary>
        /// True if Date specified.
        /// </summary>
        [XmlIgnore()]
        public bool DtSpecified { get; set; }

        /// <summary>
        /// SequenceNumber. Sequential number of the tax report.
        /// </summary>
        public decimal SeqNb { get; set; }

        /// <summary>
        /// True if SeqNb specified
        /// </summary>
        [XmlIgnore()]
        public bool SeqNbSpecified { get; set; }

        /// <summary>
        /// Records of tax details.
        /// </summary>
        [XmlElement("Rcrd")]
        public TaxRecord2[] Rcrd { get; set; }

    }
}
