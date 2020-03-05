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

    public enum PersonIdentificationType
    {

        /// <summary>
        /// Número de registro extranjero. Número asignado por una
        /// agencia gubernamental para identificar a ciudadanos extranjeros.
        /// </summary>
        AlnRegnNb,

        /// <summary>
        /// Número de cliente. Número asignado por un agente para identificar a su cliente.
        /// </summary>
        CstmrNb,

        /// <summary>
        /// Número de carnet de conducir. Número asignado por
        /// una autoridad de licencia a una licencia de conducir.
        /// </summary>
        DrvrsLicNb,

        /// <summary>
        /// Fecha y lugar de nacimiento. Fecha y lugar de nacimiento de una persona.
        /// </summary>
        DtAndPlcOfBirth,

        /// <summary>
        /// Número asignado por una autoridad fiscal a una entidad. 	
        /// Número asignado por una autoridad nacional a una tarjeta de identidad.
        /// </summary>
        IdntyCardNb,

        /// <summary>
        /// Número de identificación de empleado. Número asignado a un empleador por una autoridad de registro.
        /// </summary>
        MplyrIdNb,

        /// <summary>
        /// Otra identificación. Identificador emitido a una persona para la cual no se ha definido un identificador específico.
        /// </summary>
        OthrId,

        /// <summary>
        /// Número de pasaporte. Número asignado por una autoridad de pasaporte a un pasaporte.
        /// </summary>
        PsptNb,

        /// <summary>
        /// Número de seguridad social. Número asignado por una agencia de seguridad social.
        /// </summary>
        SclSctyNb,

        /// <summary>
        /// Número de identificación fiscal. Número asignado por una autoridad fiscal a una entidad.
        /// </summary>
        TaxIdNb,
    }


}
