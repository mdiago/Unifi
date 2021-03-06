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

namespace Unifi.Business.Pain
{

    /// <summary>
    /// Representa un pago integrado en un mensaje 
    /// del tipo CustomerDirectDebitInitiation.
    /// </summary>
    public class CustomerCreditTransferInitiationPayment
    {

        /// <summary>
        /// Conjunto de elementos utilizados para hacer referencia a una instrucción de pago.
        /// </summary>
        public string PaymentIdentification { get; set; }

        /// <summary>
        /// Modenda de la instrucción de pago.
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// Importe del pago.
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Identificación única, según lo asignado por el acreedor, para identificar inequívocamente el mandato.
        /// </summary>
        public string MandateIdentification { get; set; }

        /// <summary>
        /// Deudor del pago.
        /// </summary>
        public CustomerCreditTransferInitiationParty Creditor { get; set; }

        /// <summary>
        /// Motivo subyacente de la transacción de pago.
        /// Uso: El propósito es utilizado por los clientes finales, es decir,
        /// la parte iniciadora, el deudor (último), el acreedor (último)
        /// para proporcionar información sobre la naturaleza del pago.
        /// El propósito es un elemento de contenido, que no es utilizado
        /// para el procesamiento por ninguno de los agentes involucrados
        /// en la cadena de pago.
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// Información suministrada para permitir la correspondencia de una entrada con
        /// los artículos que la transferencia pretende liquidar, como las facturas comerciales
        /// en un sistema de cuentas por cobrar.
        /// </summary>
        public string[] RemittanceInformation { get; set; }


        /// <summary>
        /// Constructor.
        /// </summary>
        public CustomerCreditTransferInitiationPayment() 
        {

            Purpose = "CASH";

        }

    }

}
