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
    /// Specifies the period related to the tax payment.
    /// </summary>
    [Serializable()]
    public enum TaxRecordPeriodCode
    {

        /// <summary>
        /// FirstMonth
        /// </summary>
        MM01,

        /// <summary>
        /// SecondMonth
        /// </summary>
        MM02,

        /// <summary>
        /// ThirdMonth
        /// </summary>
        MM03,

        /// <summary>
        /// FourthMonth
        /// </summary>
        MM04,

        /// <summary>
        /// FifthMonth
        /// </summary>
        MM05,

        /// <summary>
        /// SixthMonth
        /// </summary>
        MM06,

        /// <summary>
        /// SeventhMonth
        /// </summary>
        MM07,

        /// <summary>
        /// EighthMonth
        /// </summary>
        MM08,

        /// <summary>
        /// NinthMonth
        /// </summary>
        MM09,

        /// <summary>
        /// TenthMonth
        /// </summary>
        MM10,

        /// <summary>
        /// EleventhMonth
        /// </summary>
        MM11,

        /// <summary>
        /// TwelfthMonth
        /// </summary>
        MM12,

        /// <summary>
        /// FirstQuarter
        /// </summary>
        QTR1,

        /// <summary>
        /// SecondQuarter
        /// </summary>
        QTR2,

        /// <summary>
        /// ThirdQuarter
        /// </summary>
        QTR3,

        /// <summary>
        /// FourthQuarter
        /// </summary>
        QTR4,

        /// <summary>
        /// FirstHalf
        /// </summary>
        HLF1,

        /// <summary>
        /// SecondHalf
        /// </summary>
        HLF2

    }

}
