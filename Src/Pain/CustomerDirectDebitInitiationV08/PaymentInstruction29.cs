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
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV08
{
    [Serializable()]
    [XmlType(Namespace = AaNamespaces.Root)]
    public class PaymentInstruction29
    {
        
        public string PmtInfId { get; set; }

        public PaymentMethod2Code PmtMtd { get; set; }

        public bool BtchBookg { get; set; }

        [XmlIgnore()]
        public bool BtchBookgSpecified { get; set; }

        public string NbOfTxs { get; set; }

        public decimal CtrlSum { get; set; }

        [XmlIgnore()]
        public bool CtrlSumSpecified { get; set; }

        public PaymentTypeInformation29 PmtTpInf { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime ReqdColltnDt { get; set; }

        public PartyIdentification Cdtr { get; set; }

        public CashAccount38 CdtrAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification6 CdtrAgt { get; set; }

        public CashAccount38 CdtrAgtAcct { get; set; }

        public PartyIdentification UltmtCdtr { get; set; }

        public ChargeBearerType1Code ChrgBr { get; set; }

        [XmlIgnore()]
        public bool ChrgBrSpecified { get; set; }

        public CashAccount38 ChrgsAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification6 ChrgsAcctAgt { get; set; }

        public PartyIdentification CdtrSchmeId { get; set; }

        [XmlElement("DrctDbtTxInf")]
        public DirectDebitTransactionInformation23[] DrctDbtTxInf { get; set; }

        /// <summary>
        /// Representación textual de la instancia.
        /// </summary>
        /// <returns>Representación textual de la instancia.</returns>
        public override string ToString()
        {
            return $"{PmtInfId}, {PmtMtd}, {PmtTpInf}";
        }

    }
}
