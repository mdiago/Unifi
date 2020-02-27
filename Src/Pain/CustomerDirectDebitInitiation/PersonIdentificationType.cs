using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unifi.Pain.CustomerDirectDebitInitiation
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
