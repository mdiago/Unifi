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

namespace Unifi.Xml.Pain.CustomerDirectDebitInitiation
{

    [Serializable()]
    public class PaymentTypeInformation
    {
        public PriorityCode InstrPrty { get; set; }

        [XmlIgnore()]
        public bool InstrPrtySpecified { get; set; }

        /// <summary>
        /// Sólo válido en la versión 1.
        /// </summary>
        public ClearingChannelCode ClrChanl { get; set; }

        [XmlIgnore()]
        public bool ClrChanlSpecified { get; set; }

        /// <summary>
        /// Acuerdo bajo el cual o reglas bajo las cuales la transacción debe ser procesada.
        /// </summary>
        public CdOrPrtryTypeChoice SvcLvl { get; set; }

        /// <summary>
        /// Instrumento específico de la comunidad de usuarios.
        /// Uso: Este elemento se usa para especificar un instrumento
        /// local, una opción de compensación local y / o calificar aún
        /// más el servicio o nivel de servicio.
        /// </summary>
        public CdOrPrtryTypeChoice LclInstrm { get; set; }

        public SequenceTypeCode SeqTp { get; set; }

        [XmlIgnore()]
        public bool SeqTpSpecified { get; set; }

        /// <summary>
        /// Especifica el propósito de alto nivel de la instrucción en función de un conjunto de categorías predefinidas. 
        /// Uso: La parte iniciadora lo utiliza para proporcionar información sobre el procesamiento del pago.
        /// Es probable que desencadene un procesamiento especial por parte de cualquiera de los agentes involucrados
        /// en la cadena de pago.
        /// </summary>
        [XmlElement("CtgyPurp", typeof(PaymentCategoryPurposeCode), Namespace = Namespaces.V01)]
        [XmlElement("CtgyPurp", typeof(CdOrPrtryTypeChoice), Namespace = Namespaces.V02)]
        public virtual object CtgyPurp { get; set; }

        [XmlIgnore()]
        public bool CtgyPurpSpecified { get; set; }

    }

}
