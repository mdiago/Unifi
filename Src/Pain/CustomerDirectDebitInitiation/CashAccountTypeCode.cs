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

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// Enumeración únicamente válida para las versiones
    /// 1 y 2. Clasificación de tipos de cuenta en entidad
    /// financiera.
    /// </summary>
    public enum CashAccountTypeCode
    {

        /// <summary>
        /// Cuenta utilizada para el pago de efectivo.
        /// </summary>
        CASH,

        /// <summary>
        /// Cuenta utilizada para cargos si es diferente de la cuenta para pago.
        /// </summary>
        CHAR,

        /// <summary>
        /// Cuenta utilizada para comisión si es diferente de la cuenta para pago.
        /// </summary>
        COMM,

        /// <summary>
        /// Cuenta utilizada para impuestos si es diferente de la cuenta para pago.
        /// </summary>
        TAXE,

        /// <summary>
        /// Cuenta utilizada para el pago de ingresos si es diferente de la cuenta de efectivo actual.
        /// </summary>
        CISH,

        /// <summary>
        /// Cuenta utilizada para operar si es diferente de la cuenta de efectivo actual.
        /// </summary>
        TRAS,

        /// <summary>
        /// Cuenta utilizada para registrar entradas de débito y crédito, como resultado de transacciones
        /// liquidadas y liquidadas a través de un sistema específico de compensación y liquidación.
        /// </summary>
        SACC,

        /// <summary>
        /// Cuenta utilizada para registrar débitos y créditos cuando no se ha designado una cuenta específica.
        /// </summary>
        CACC,

        /// <summary>
        /// Cuenta utilizada para ahorro.
        /// </summary>
        SVGS,

        /// <summary>
        /// Cuenta utilizada para depósitos a la vista.
        /// </summary>
        ONDP,

        /// <summary>
        /// Cuenta utilizada para depósitos a la vista.
        /// </summary>
        MGLD,

        /// <summary>
        /// Cuenta utilizada para no residentes externos.
        /// </summary>
        NREX,

        /// <summary>
        /// Cuenta utilizada para mercados monetarios si es diferente de la cuenta de efectivo.
        /// </summary>
        MOMA,

        /// <summary>
        /// Cuenta utilizada para préstamos.
        /// </summary>
        LOAN,

        /// <summary>
        /// Cuentas utilizadas para pagos salariales.
        /// </summary>
        SLRY,

        /// <summary>
        /// La cuenta se usa para sobregiros.
        /// </summary>
        ODFT

    }

}
