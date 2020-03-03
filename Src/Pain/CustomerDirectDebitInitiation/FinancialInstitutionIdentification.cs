using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// Especifica los detalles para identificar una institución financiera.
    /// </summary>
    public partial class FinancialInstitutionIdentification
    {

        /// <summary>
        /// Unicamente válido en la versión 1.
        /// </summary>
        [XmlElement("CmbndId", typeof(FinancialInstitutionIdentification))]
        [XmlElement("NmAndAdr", typeof(NameAndAddress))]
        [XmlElement("PrtryId", typeof(GenericIdentification))]
        public object Item { get; set; }

        /// <summary>
        /// Sólo válido en la versión 2. Código asignado a una institución 
        /// financiera por la Autoridad de Registro ISO 9362 como se describe
        /// en ISO 9362 "Banca - Mensajes de telecomunicaciones bancarias - 
        /// Código de identificación comercial (BIC)".
        /// </summary>
        public string BIC { get; set; } 

        /// <summary>
        /// A partir de la versión 3. Código asignado a una institución 
        /// financiera por la Autoridad de Registro ISO 9362 como se describe 
        /// en ISO 9362 "Banca - Mensajes de telecomunicaciones bancarias - 
        /// Código de identificación comercial (BIC)".
        /// </summary>
        public string BICFI { get; set; }

        /// <summary>
        /// A partir de la versión 8. Identificador de la entidad jurídica de la institución financiera.
        /// </summary>
        public string LEI { get; set; }


        /// <summary>
        /// Información utilizada para identificar a un miembro dentro de un sistema de compensación.
        /// </summary>
        public ClearingSystemMemberIdentification ClrSysMmbId { get; set; } 

        /// <summary>
        /// Nombre por el que se conoce un agente y que generalmente se usa para identificar a ese agente.
        /// </summary>
        public string Nm { get; set; }

        /// <summary>
        /// Información que localiza e identifica una dirección específica, según lo definido por los servicios postales.
        /// </summary>
        [XmlElement("PstlAdr", typeof(PostalAddress))]
        public virtual object PstlAdr { get; set; }

        /// <summary>
        /// Identificación única de un agente, según lo asignado por una institución,
        /// utilizando un esquema de identificación.
        /// </summary>
        public GenericIdentificationCdOrPrtry Othr { get; set; }

    }


}

