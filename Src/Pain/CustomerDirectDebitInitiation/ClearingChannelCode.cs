using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// Especifica el canal de compensación para el enrutamiento de la transacción, como parte de la identificación del tipo de pago.
    /// </summary>
    public enum ClearingChannelCode
    {

        /// <summary>
        /// El canal de compensación es un sistema de liquidación bruta en tiempo real.
        /// </summary>
        RTGS,

        /// <summary>
        /// El canal de compensación es un sistema de liquidación neta en tiempo real.
        /// </summary>
        RTNS,

        /// <summary>
        /// El canal de compensación es un sistema de liquidación neta de pagos masivos.
        /// </summary>
        MPNS,

        /// <summary>
        /// Pago mediante transferencia interna de libros.
        /// </summary>
        BOOK
    }


}
