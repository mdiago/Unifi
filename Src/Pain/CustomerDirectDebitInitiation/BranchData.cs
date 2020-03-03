using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// Información que localiza e identifica una sucursal específica de una institución financiera.
    /// </summary>
    public partial class BranchData
    {

        /// <summary>
        /// Identificación única e inequívoca de una sucursal de una institución financiera.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Nombre por el que se conoce un agente y que generalmente se usa para identificar a ese agente.
        /// </summary>
        public string Nm { get; set; }

        /// <summary>
        /// ´Válido a partir de la versión 8. Identificación de la entidad jurídica de la sucursal de la institución financiera.
        /// </summary>
        public string LEI { get; set; }

        /// <summary>
        /// Información que localiza e identifica una dirección específica, según lo definido por los servicios postales.
        /// </summary>
        public PostalAddress PstlAdr { get; set; }

    }

}
