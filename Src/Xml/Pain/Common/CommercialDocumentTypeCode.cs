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

namespace Unifi.Xml.Pain.Common
{

    /// <summary>
    /// Document type in a coded form.
    /// </summary>
    [Serializable()]
    public enum CommercialDocumentTypeCode
    {

        /// <summary>
        /// MeteredServiceInvoice. Document is an invoice claiming
        /// payment for the supply of metered
        /// services, for example gas or electricity
        /// supplied to a fixed meter.
        /// </summary>
        MSIN,

        /// <summary>
        /// CreditNoteRelatedToFinancialAdjustment. Document is a credit note for the final
        /// amount settled for a commercial
        /// transaction.
        /// </summary>
        CNFA,

        /// <summary>
        /// DebitNoteRelatedToFinancialAdjustment. Document is a debit note for the final
        /// amount settled for a commercial
        /// transaction.
        /// </summary>
        DNFA,

        /// <summary>
        /// CommercialInvoice. Document is an invoice.
        /// </summary>
        CINV,

        /// <summary>
        /// CreditNote. Document is a credit note.
        /// </summary>
        CREN,

        /// <summary>
        /// DebitNote. Document is a debit note.
        /// </summary>
        DEBN,

        /// <summary>
        /// HireInvoice. Document is an invoice for the hiring of
        /// human resources or renting goods or
        /// equipment.
        /// </summary>
        HIRI,

        /// <summary>
        /// SelfBilledInvoice. Document is an invoice issued by the
        /// debtor.
        /// </summary>
        SBIN,

        /// <summary>
        /// CommercialContract. Document is an agreement between the
        /// parties, stipulating the terms and
        /// conditions of the delivery of goods or
        /// services.
        /// </summary>
        CMCN,

        /// <summary>
        /// StatementOfAccount. Document is a statement of the
        /// transactions posted to the debtor's
        /// account at the supplier.
        /// </summary>
        SOAC,

        /// <summary>
        /// DispatchAdvice. Document is a dispatch advice.
        /// </summary>
        DISP,

        /// <summary>
        /// BillOfLading. Document is a shipping notice. A partir de la verión 2.
        /// </summary>
        BOLD,

        /// <summary>
        /// Voucher. Document is an electronic payment document. A partir de la verión 2.
        /// </summary>
        VCHR,

        /// <summary>
        /// AccountReceivableOpenItem. Document is a payment that applies to a
        /// specific source document. A partir de la verión 2.
        /// </summary>
        AROI,

        /// <summary>
        /// TradeServicesUtilityTransaction. Document is a transaction identifier as
        /// assigned by the Trade Services Utility. A partir de la verión 2.
        /// </summary>
        TSUT,

        /// <summary>
        /// PurchaseOrder. Document is a purchase order. A partir de la versión 5.
        /// </summary>
        PUOR

    }
}
