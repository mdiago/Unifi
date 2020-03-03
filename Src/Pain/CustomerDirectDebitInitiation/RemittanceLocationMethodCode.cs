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
    /// Especifica el método utilizado para entregar la información del aviso de envío.
    /// </summary>
    public enum RemittanceLocationMethodCode
    {

        /// <summary>
        /// La información del aviso de envío debe enviarse por fax.
        /// </summary>
        FAXI,

        /// <summary>
        /// La información del aviso de envío debe enviarse a través
        /// del intercambio electrónico de datos (EDI).
        /// </summary>
        EDIC,

        /// <summary>
        /// La información de asesoramiento de envío debe enviarse a
        /// un Identificador Uniforme de Recursos (URI). URI es una
        /// cadena compacta de caracteres que identifica de forma exclusiva
        /// un recurso abstracto o físico. Los URI son el superconjunto
        /// de identificadores, como URL, direcciones de correo electrónico,
        /// sitios ftp, etc., y como tales, proporcionan la sintaxis para
        /// todos los esquemas de identificación.
        /// </summary>
        URID,

        /// <summary>
        /// La información del aviso de envío debe enviarse por correo
        /// electrónico.
        /// </summary>
        EMAL,

        /// <summary>
        ///  La información del aviso de envío debe enviarse a través
        ///  de los servicios postales.
        /// </summary>
        POST,

        /// <summary>
        /// La información del aviso de envío debe enviarse por teléfono
        /// como un servicio de mensajes cortos (SMS).
        /// </summary>
        SMSM
    }



}

