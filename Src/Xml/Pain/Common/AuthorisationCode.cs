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
    /// Especifica el nivel de aprobación en función de una serie de factores,
    /// incluido el tipo de pago, el importe umbral o el país local o la
    /// práctica de operaciones.
    /// </summary>
    public enum AuthorisationCode
    {


        /// <summary>
        /// <para>PreAuthorisedFile</para>
        /// <para>Indicates a file has been pre authorised or approved 
        /// within the originating customer environment and no further 
        /// approval is required.</para>
        /// </summary>
        AUTH,

        /// <summary>
        /// <para>FileLevelAuthorisationDetails</para>
        /// <para>Indicates that a file requires additional file level 
        /// approval, with the ability to view both the payment information 
        /// block and supporting customer credit transaction detail.</para>
        /// </summary>
        FDET,

        /// <summary>
        /// <para>FileLevelAuthorisationSummary</para>
        /// <para>Indicates that a file requires additional file level approval, 
        /// with the ability to view only the payment information block level 
        /// information. </para>
        /// </summary>
        FSUM,

        /// <summary>
        /// <para>InstructionLevelAuthorisation</para>
        /// <para>Indicates that a file requires all customer transactions to 
        /// be authorised or approved</para>
        /// </summary>
        ILEV

    }

}
