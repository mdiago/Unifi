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
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV08
{

    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the
    /// payment is intended to settle, such as commercial invoices in an accounts' receivable system, in a
    /// structured form.
    /// </summary>
    [Serializable()]
    [XmlType(Namespace = AaNamespaces.Root)]
    public class StructuredRemittanceInformation16
    {

        /// <summary>
        /// ReferredDocumentInformation. Provides the identification and the content of the referred document.
        /// </summary>
        [XmlElement("RfrdDocInf")]
        public ReferredDocumentInformation7[] RfrdDocInf { get; set; }

        /// <summary>
        /// ReferredDocumentAmount. Provides details on the amounts of the referred document.
        /// </summary>
        public RemittanceAmount2 RfrdDocAmt { get; set; }

        /// <summary>
        /// CreditorReferenceInformation. Reference information provided by the creditor to allow the identification of the underlying
        /// documents.
        /// </summary>
        public CreditorReferenceInformation CdtrRefInf { get; set; }

        /// <summary>
        /// Invoicer. Identification of the organisation issuing the invoice, when it is different from the creditor or
        /// ultimate creditor.
        /// </summary>
        public PartyIdentification Invcr { get; set; }

        /// <summary>
        /// Invoicee. Identification of the party to whom an invoice is issued, when it is different from the debtor or
        /// ultimate debtor.
        /// </summary>
        public PartyIdentification Invcee { get; set; }

        /// <summary>
        /// TaxRemittance. Provides remittance information about a payment made for tax-related purposes.
        /// </summary>
        public TaxInformation TaxRmt { get; set; }

        /// <summary>
        /// GarnishmentRemittance. Provides remittance information about a payment for garnishment-related purposes.
        /// </summary>
        public Garnishment3 GrnshmtRmt { get; set; }

        /// <summary>
        /// AdditionalRemittanceInformation. Additional information, in free text form, 
        /// to complement the structured remittance information. Max140Text. [0..3].
        /// </summary>
        [XmlElement("AddtlRmtInf")]
        public string[] AddtlRmtInf { get; set; }

    }
}
