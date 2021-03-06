﻿/*
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

namespace Unifi.Xml.Pain.Common
{

    /// <summary>
    ///  Amount due and payable to the creditor.
    /// </summary>
    [Serializable()]
    public class RemittanceAmount
    {

        /// <summary>
        /// DuePayableAmount. Amount specified is the exact amount due and payable to the creditor.
        /// </summary>
        public ActiveOrHistoricCurrencyAndAmount DuePyblAmt { get; set; }

        /// <summary>
        /// DiscountAppliedAmount. Amount of discount to be applied to the amount due and payable to the creditor.
        /// </summary>
        [XmlElement("DscntApldAmt")]
        public DiscountAmountAndType[] DscntApldAmt { get; set; }

        /// <summary>
        /// CreditNoteAmount. Amount of a credit note.
        /// </summary>
        public ActiveOrHistoricCurrencyAndAmount CdtNoteAmt { get; set; }

        /// <summary>
        /// TaxAmount. Amount of the tax.
        /// </summary>
        [XmlElement("TaxAmt")]
        public TaxAmountAndType[] TaxAmt { get; set; }

        /// <summary>
        /// AdjustmentAmountAndReason. Specifies detailed information on the amount and reason of the adjustment.
        /// </summary>
        [XmlElement("AdjstmntAmtAndRsn")]
        public DocumentAdjustment[] AdjstmntAmtAndRsn { get; set; }

        /// <summary>
        /// RemittedAmount. Amount of money remitted.
        /// </summary>
        public ActiveOrHistoricCurrencyAndAmount RmtdAmt { get; set; }

    }
}
