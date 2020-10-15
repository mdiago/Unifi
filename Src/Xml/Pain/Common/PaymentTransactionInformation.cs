/*
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
using Unifi.Xml.Pain.Common;

namespace Unifi.Xml.Pain.Common
{

    /// <summary>
    /// Proporciona más detalles específicos de las transacciones de débito directo individuales incluidas en el mensaje.
    /// </summary>
    [Serializable()]
    public class PaymentTransactionInformation
    {

        /// <summary>
        /// Conjunto de elementos utilizados para hacer referencia a una instrucción de pago.
        /// </summary>
        public PaymentIdentification PmtId { get; set; }

        /// <summary>
        /// Conjunto de elementos utilizados para especificar aún más el tipo de transacción.
        /// </summary>
        public PaymentTypeInformation PmtTpInf { get; set; }

        /// <summary>
        /// Cantidad de dinero que se moverá entre el deudor y el acreedor, antes de la
        /// deducción de los cargos, expresada en la moneda ordenada por la parte iniciadora.
        /// </summary>
        public ActiveOrHistoricCurrencyAndAmount InstdAmt { get; set; }

        /// <summary>
        /// Especifica qué parte / partes asumirán los cargos asociados con el
        /// procesamiento de la transacción de pago.
        /// </summary>
        public ChargeBearerTypeCode ChrgBr { get; set; }

        /// <summary>
        /// True si ChrgBrSpecified especificado.
        /// </summary>
        [XmlIgnore()]
        public bool ChrgBrSpecified { get; set; }

        /// <summary>
        /// Interlocutor final a la que se debe una cantidad de dinero.
        /// </summary>
        public PartyIdentification UltmtCdtr { get; set; }

 
        /// <summary>
        ///  La última parte que le debe una cantidad de dinero al(último) acreedor.
        /// </summary>
        public PartyIdentification UltmtDbtr { get; set; }

        /// <summary>
        /// Información adicional, relacionada con el procesamiento de la instrucción
        /// de pago, que el agente acreedor deba tener en cuenta, según el acuerdo
        /// entre el acreedor y el agente acreedor.
        /// </summary>
        public string InstrForCdtrAgt { get; set; }

    }

}
