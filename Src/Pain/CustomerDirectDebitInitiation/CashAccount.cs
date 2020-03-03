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

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// Proporciona los detalles para identificar una cuenta.
    /// </summary>
    [Serializable()]
    public partial class CashAccount
    {

        /// <summary>
        /// Identificación única e inequívoca de la cuenta entre el 
        /// propietario de la cuenta y el administrador de la cuenta.
        /// </summary>
        public AccountIdentificationChoice Id { get; set; }

        /// <summary>
        /// Especifica la naturaleza o el uso de la cuenta.
        /// </summary>
        public CdOrPrtryTypeChoice Tp { get; set; }

        /// <summary>
        /// Identificación de la moneda en la que se mantiene la cuenta.
        /// Uso: la moneda solo debe usarse en caso de que el mismo número de cuenta cubra varias monedas
        /// y la parte iniciadora necesita identificar qué moneda debe usarse para la liquidación de la cuenta.
        /// </summary>
        public string Ccy { get; set; }

        /// <summary>
        /// Nombre de la cuenta, según lo asignado por la institución de servicio de la cuenta,
        /// de acuerdo con el propietario de la cuenta para proporcionar un medio adicional de
        /// identificación de la cuenta.
        /// Uso: El nombre de la cuenta es diferente del nombre del propietario de la cuenta.
        /// El nombre de la cuenta se utiliza en ciertas comunidades de usuarios para proporcionar 
        /// un medio de identificación de la cuenta, además de la identidad del propietario de la
        /// cuenta y el número de cuenta.
        /// </summary>
        public string Nm { get; set; }

        /// <summary>
        /// Válido a partir de la versión 8. 
        /// Especifica un nombre supuesto alternativo para la identificación de la cuenta. 
        /// </summary>
        public ProxyAccountIdentification Prxy { get; set; }

        /// <summary>
        /// Representación textual de la instancia.
        /// </summary>
        /// <returns>Representación textual de la instancia.</returns>
        public override string ToString()
        {
            return $"{Id}, {Tp}, {Nm}";
        }

    }



}

