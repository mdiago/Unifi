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

namespace Unifi.Xml.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// Especifica el tipo de transacción que resultó en el pago.
    /// </summary>
    public enum PaymentCategoryPurposeCode
    {

        /// <summary>
        /// La transacción está relacionada con la liquidación de una
        /// operación, por ejemplo, un acuerdo de cambio o una
        /// transacción de valores.
        /// </summary>
        CORT,

        /// <summary>
        /// La transacción es el pago de salarios.
        /// </summary>
        SALA,

        /// <summary>
        /// La transacción está relacionada con las operaciones de tesorería.
        /// </summary>
        TREA,

        /// <summary>
        /// La transacción es una instrucción general de gestión de efectivo.
        /// </summary>
        CASH,

        /// <summary>
        /// La transacción es el pago de dividendos.
        /// </summary>
        DIVI,

        /// <summary>
        /// La transacción es un pago hacia o desde un departamento gubernamental.
        /// </summary>
        GOVT,

        /// <summary>
        /// La transacción es el pago de intereses.
        /// </summary>
        INTE,

        /// <summary>
        /// La transacción está relacionada con la transferencia de un préstamo a un prestatario.
        /// </summary>
        LOAN,

        /// <summary>
        /// La transacción es el pago de la pensión.
        /// </summary>
        PENS,

        /// <summary>
        /// La transacción es el pago de valores.
        /// </summary>
        SECU,

        /// <summary>
        /// La transacción es un beneficio de la seguridad social,
        /// es decir, el pago realizado por un gobierno para apoyar
        /// a las personas.
        /// </summary>
        SSBE,

        /// <summary>
        /// La transacción está relacionada con un pago a un proveedor.
        /// </summary>
        SUPP,

        /// <summary>
        /// La transacción es el pago de impuestos.
        /// </summary>
        TAXS,

        /// <summary>
        /// La transacción está relacionada con el pago de una transacción comercial.
        /// </summary>
        TRAD,

        /// <summary>
        /// La transacción es el pago del impuesto al valor agregado.
        /// </summary>
        VATX,

        /// <summary>
        /// La transacción está relacionada con el pago de una operación de cobertura.
        /// </summary>
        HEDG,

        /// <summary>
        /// La transacción es un pago dentro de la empresa, es decir,
        /// un pago entre dos empresas que pertenecen al mismo grupo.
        /// </summary>
        INTC,

        /// <summary>
        /// La transacción es el pago de la retención de impuestos.
        /// </summary>
        WHLD

    }


}
