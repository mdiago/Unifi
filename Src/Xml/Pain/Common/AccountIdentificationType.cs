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

namespace Unifi.Xml.Pain.Common
{

    /// <summary>
    /// Tipos de identificador de cuenta.
    /// </summary>
    public enum AccountIdentificationType
    {

        /// <summary>
        /// Número de cuenta bancaria básica (BBAN): identificador utilizado
        /// a nivel nacional por las instituciones financieras, es decir,
        /// en países individuales, generalmente como parte de un esquema
        /// o esquemas de numeración de cuenta nacional, para identificar
        /// de forma única la cuenta de un cliente.
        /// </summary>
        BBAN,

        /// <summary>
        /// Número de cuenta bancaria internacional (IBAN): identificador 
        /// utilizado internacionalmente por las instituciones financieras 
        /// para identificar de forma exclusiva la cuenta de un cliente. 
        /// Se pueden encontrar especificaciones adicionales del formato 
        /// y contenido del IBAN en la norma ISO 13616 "Banca y servicios 
        /// financieros relacionados - Número de cuenta bancaria 
        /// internacional (IBAN)" versión 1997-10-01, o revisiones 
        /// posteriores.
        /// </summary>
        IBAN,

        /// <summary>
        /// Número de cuenta utilizado por las instituciones financieras
        /// en países individuales para identificar una cuenta de un cliente,
        /// pero no necesariamente el banco y la sucursal de la institución
        /// financiera en la que se encuentra la cuenta.
        /// </summary>
        PrtryAcct,

        /// <summary>
        /// Código de identificación de pago universal (UPIC): identificador 
        /// utilizado por la Cámara de compensación de Nueva York para
        /// enmascarar datos confidenciales, como cuentas bancarias y
        /// números de ruta bancaria. Los números UPIC permanecen con
        /// clientes comerciales, independientemente de los cambios en
        /// las relaciones bancarias.
        /// </summary>
        UPIC,

        /// <summary>
        /// Información relacionada con una identificación de cuenta genérica.
        /// </summary>
        Othr
    }

}
