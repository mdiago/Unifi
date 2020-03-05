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

using System.Xml.Serialization;
using Unifi.Xml.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Xml.Pain.CustomerDirectDebitInitiationV01
{

    /// <summary>
    /// <para>Versión 5. Alcance:</para>
    /// <para>La parte iniciadora envía el mensaje CustomerDirectDebitInitiation
    /// al agente de reenvío o al agente acreedor.Se utiliza para solicitar una
    /// o varias colecciones de fondos de una o varias cuentas del deudor para
    /// un acreedor.</para>
    /// <para>Uso</para>
    /// <para>El mensaje CustomerDirectDebitInitiation puede contener una o más
    /// instrucciones de débito directo.</para>
    /// <para>El mensaje puede usarse en un escenario directo o de retransmisión:</para>
    /// <para>   - En un escenario directo, el mensaje se envía directamente al agente
    /// acreedor. El agente acreedor es el administrador de la cuenta del acreedor.</para>
    /// <para>   - En un escenario de retransmisión, el mensaje se envía a un
    /// agente de reenvío.El agente expedidor actúa como una institución financiera
    /// concentradora.Reenviará el mensaje CustomerDirectDebitInitiation al agente
    /// acreedor.</para>
    /// <para>El mensaje también puede ser utilizado por una parte iniciadora que tiene
    /// autoridad para enviar el mensaje en nombre del acreedor.Esto atiende, por ejemplo,
    /// al escenario de una fábrica de pagos que inicia todos los pagos en nombre de una
    /// gran empresa.</para>
    ///  <para>El mensaje CustomerDirectDebitInitiation se puede utilizar en escenarios
    ///  nacionales y transfronterizos.</para>
    /// <para>CustomerDirectDebitInitiation puede o no contener información relacionada
    /// con el mandato, es decir, extractos de un mandato, como MandateIdentification
    /// o DateOfSignature. El mensaje CustomerDirectDebitInitiation no debe considerarse
    /// como un mandato.</para>
    /// <para>El agente acreedor no debe utilizar el mensaje CustomerDirectDebitInitiation
    /// para ejecutar las instrucciones de domiciliación bancaria. En su lugar, debe usarse
    /// el mensaje FIToFICustomerDirectDebit.</para>
    /// </summary>    
    [XmlType(TypeName = "pain.008.001.01")]
    public class pain00800101
    {

        /// <summary>
        /// Cabecera del mensaje.
        /// </summary>
        public GroupHeader GrpHdr { get; set; }

        /// <summary>
        /// Información del mensaje.
        /// </summary>
        [XmlElement("PmtInf")]
        public PaymentInstruction[] PmtInf { get; set; }

    }
}
