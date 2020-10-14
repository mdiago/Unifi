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

namespace Unifi.Xml.Pain.Common
{

    /// <summary>
    /// Detalles sobre los impuestos pagados, o por pagar, al gobierno de
    /// conformidad con la ley, incluidos los parámetros predefinidos, como
    /// los umbrales y el tipo de cuenta.
    /// </summary>
    [Serializable()]
    public class TaxInformation
    {

        /// <summary>
        /// Sólo versión 1. 	
        /// Parte del lado del crédito de la transacción
        /// a la que se aplica el impuesto.
        /// </summary>
        public string CdtrTaxId { get; set; }

        /// <summary>
        /// Sólo versión 1.
        /// </summary>
        public string CdtrTaxTp { get; set; }

        /// <summary>
        /// Sólo versión 1. 	
        /// Parte en el lado de débito de la transacción a la
        /// que se aplica el impuesto.
        /// </summary>
        public string DbtrTaxId { get; set; }

        /// <summary>
        /// Sólo versión 1. Tax reference information that is specific to a taxing agency.
        /// </summary>
        public string TaxRefNb { get; set; }

        /// <summary>
        /// Sólo versión 1. Date by which tax is due.
        /// </summary>
        [XmlElement(DataType = "date")]
        public DateTime TaxDt { get; set; }

        /// <summary>
        /// True si taxDt especificado.
        /// </summary>
        [XmlIgnore()]
        public bool TaxDtSpecified { get; set; }

        /// <summary>
        /// Sólo versión 1. 	
        /// Records of tax details.
        /// </summary>
        [XmlElement("TaxTpInf")]
        public TaxRecord[] TaxTpInf { get; set; }


        /// <summary>
        /// Creditor. Party on the credit side of the transaction to which the tax applies.
        /// </summary>
        public TaxParty Cdtr { get; set; }

        /// <summary>
        /// Identifies the party on the debit side of the transaction to which the tax applies.
        /// </summary>
        public TaxParty Dbtr { get; set; }

        /// <summary>
        /// UltimateDebtor. Ultimate party that owes an amount of money to the (ultimate) creditor, in this case, to the
        /// taxing authority.
        /// </summary>
        public TaxParty UltmtDbtr { get; set; }

        /// <remarks/>
        public string AdmstnZone { get; set; }

        /// <remarks/>
        public string RefNb { get; set; }

        /// <remarks/>
        public string Mtd { get; set; }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt { get; set; }

        /// <remarks/>
        public ActiveOrHistoricCurrencyAndAmount TtlTaxAmt { get; set; }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public DateTime Dt { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool DtSpecified { get; set; }

        /// <remarks/>
        public decimal SeqNb { get; set; }

        /// <remarks/>
        [XmlIgnore()]
        public bool SeqNbSpecified { get; set; }

        /// <remarks/>
        [XmlElement("Rcrd")]
        public TaxRecord[] Rcrd { get; set; }

    }
}
