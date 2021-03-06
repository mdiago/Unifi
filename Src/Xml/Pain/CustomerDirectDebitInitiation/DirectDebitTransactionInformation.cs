﻿/*
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
using Unifi.Xml.Pain.Common;

namespace Unifi.Xml.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// Proporciona más detalles específicos de las transacciones de débito directo individuales incluidas en el mensaje.
    /// </summary>
    [Serializable()]
    public class DirectDebitTransactionInformation : PaymentTransactionInformation
    {


        /// <summary>
        /// Especifica qué parte / partes asumirán los cargos asociados con el procesamiento de la transacción de pago.
        /// </summary>
        public PaymentTransaction DrctDbtTx { get; set; }

        /// <summary>
        /// Institución financiera que atiende una cuenta para el deudor.
        /// </summary>
        public BranchAndFinancialInstitutionIdentification DbtrAgt { get; set; }

        /// <summary>
        /// Identificación inequívoca de la cuenta del agente deudor en su agente de servicio en la cadena de pago.
        /// </summary>
        public CashAccount DbtrAgtAcct { get; set; }

        /// <summary>
        ///  Parte que debe una cantidad de dinero al(último) acreedor.
        /// </summary>
        public PartyIdentification Dbtr { get; set; }

        /// <summary>
        /// Identificación inequívoca de la cuenta del deudor a la que se realizará
        /// una entrada de débito como resultado de la transacción.
        /// </summary>
        public CashAccount DbtrAcct { get; set; }

        /// <summary>
        /// Motivo subyacente de la transacción de pago.
        /// Uso: El propósito es utilizado por los clientes finales, es decir,
        /// la parte iniciadora, el deudor (último), el acreedor (último)
        /// para proporcionar información sobre la naturaleza del pago.
        /// El propósito es un elemento de contenido, que no es utilizado
        /// para el procesamiento por ninguno de los agentes involucrados
        /// en la cadena de pago.
        /// </summary>
        public CdOrPrtryTypeChoice Purp { get; set; }

        /// <summary>
        ///  Información necesaria debido a requisitos reglamentarios y legales.
        /// </summary>
        [XmlElement("RgltryRptg")]
        public RegulatoryReporting[] RgltryRptg { get; set; }

        /// <summary>
        /// Proporciona detalles sobre el impuesto.
        /// </summary>
        public TaxInformation Tax { get; set; }

        /// <summary>
        /// Proporciona información relacionada con el manejo de la información de remesas
        /// por parte de cualquiera de los agentes en la cadena de procesamiento de transacciones.
        /// </summary>
        [XmlElement("RltdRmtInf")]
        public RemittanceLocation[] RltdRmtInf { get; set; }

        /// <summary>
        /// Información suministrada para permitir la correspondencia de una entrada con
        /// los artículos que la transferencia pretende liquidar, como las facturas comerciales
        /// en un sistema de cuentas por cobrar.
        /// </summary>
        public RemittanceInformation RmtInf { get; set; }

        /// <summary>
        /// Información adicional que no se puede capturar en los elementos estructurados
        /// y / o cualquier otro bloque específico.
        /// </summary>
        [XmlElement("SplmtryData")]
        public SupplementaryData[] SplmtryData { get; set; }

        /// <summary>
        /// Representación textual de la instancia.
        /// </summary>
        /// <returns>Representación textual de la instancia.</returns>
        public override string ToString()
        {
            return $"{Dbtr}, {DbtrAcct}, {InstdAmt}";
        }

    }

}
