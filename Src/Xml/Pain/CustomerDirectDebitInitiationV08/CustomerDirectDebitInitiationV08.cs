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
using Unifi.Xml.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Xml.Pain.CustomerDirectDebitInitiationV08
{

    /// <summary>
    /// <para>MENSAJE DE INICIACIÓN DE ADEUDOS DIRECTOS.</para>
    /// El mensaje ISO 20022 de iniciación de adeudos directos básicos por el cliente (pain.008.001.08.
    /// </summary>
    [Serializable()]
    [XmlType(Namespace = Namespaces.V08)]
    public class CustomerDirectDebitInitiationV08
    {


        /// <summary>
        /// <para>Cabecera (Group Header)</para>
        /// <para>El bloque de cabecera es obligatorio y sólo aparece una vez. 
        /// Contiene elementos comunes a todo el mensaje. 
        /// Los siguientes elementos tienen que estar siempre presentes:</para>
        /// <para>  - Identificación de mensaje / Message Identification</para>
        /// <para>  - Fecha y hora de creación / Creation Date Time</para>
        /// <para>  - Número de operaciones / Number Of Transactions 
        ///             ('1' si el mensaje contiene una única operación, 
        ///             'n' en el caso de que contenga múltiples)</para>
        /// <para>  - Presentador/ Initiating Party (parte que envía el mensaje)</para>
        /// </summary>
        public GroupHeader GrpHdr { get; set; }

        /// <summary>
        /// <para>Información del pago (Payment Information)</para>
        /// <para>El bloque de Información del pago es obligatorio y puede repetirse. 
        /// Contiene elementos del ámbito del acreedor de la operación. 
        /// Los elementos que siempre aparecen en este bloque son:</para>
        /// <para>  - Identificación de la información del pago / Payment Information Identification</para>
        /// <para>  - Método de pago / Payment Method</para>
        /// <para>  - Fecha de cobro / Requested Collection Date</para>
        /// <para>  - Acreedor/ Creditor</para>
        /// <para>  - Cuenta del acreedor/ Creditor Account</para>
        /// <para>  - Entidad del acreedor/ Creditor Agent</para>
        /// <para>Todas las operaciones dentro del este bloque deben tener la misma cuenta 
        /// del acreedor y entidad del acreedor, la misma fecha de cobro solicitada 
        /// y el mismo medio de pago. Por lo tanto, si la parte iniciadora o el acreedor tienen 
        /// que emitir adeudos en un mismo mensaje, por ejemplo, para su abono en diferentes 
        /// cuentas o con distintas fechas de ejecución, deberán utilizar bloques de Información 
        /// del pago diferentes para cada cuenta y fecha.</para>
        /// <para>Hay ciertos elementos que pueden aparecer una única vez, o bien repetirse en el 
        /// bloque de información del pago, o bien en el bloque de información de adeudo directo 
        /// básico individual, a elección del emisor, pero no pueden aparecer en los dos. 
        /// Por ejemplo:</para>
        /// <para>  - Ultimo acreedor / Ultimate acreedor</para>
        /// <para>  - Cláusula de gastos / Charges Bearer</para>
        /// </summary>
        [XmlElement("PmtInf")]
        public PaymentInstruction[] PmtInf { get; set; }

        /// <summary>
        /// <para>Información del adeudo directo individual (Direct Debit transaction information)</para>
        /// <para>El bloque de Información de adeudo directo individual forma parte del bloque de información del pago. 
        /// Es obligatorio y puede repetirse “n” veces. Contiene elementos del ámbito del deudor de la operación, tales 
        /// como identificación del adeudo, importe, entidad del deudor, deudor y concepto de la operación.</para>
        /// <para>Se denomina instrucción de adeudo directo a la combinación del bloque de información del pago (C) 
        /// más el bloque de información de adeudo directo básico (D).</para>
        /// </summary>
        [XmlElement("SplmtryData")]
        public SupplementaryData[] SplmtryData { get; set; }

        /// <summary>
        /// Representación textual de la instancia.
        /// </summary>
        /// <returns>Representación textual de la instancia.</returns>
        public override string ToString()
        {
            return $"{GrpHdr}, {PmtInf?.Length}";
        }

    }
}
