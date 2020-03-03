using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// El pago debe ejecutarse con el mismo valor para el acreedor.
    /// </summary>
    public enum ServiceLevelCode
    {

        /// <summary>
        /// El pago debe ejecutarse siguiendo el esquema del Área Única de Pagos en Euros.
        /// </summary>
        SEPA,

        /// <summary>
        /// El pago debe ejecutarse con el mismo valor para el acreedor.
        /// </summary>
        SDVA,
    }


}
