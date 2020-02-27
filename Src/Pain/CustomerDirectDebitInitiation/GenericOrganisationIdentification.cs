using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// A utilizar a partir de la versión 2. 	
    /// Identificación única de una organización, según lo asignado
    /// por una institución, utilizando un esquema de identificación.
    /// </summary>
    public partial class GenericOrganisationIdentification
    {

        public string Id { get; set; }

        public CdOrPrtryTypeChoice SchmeNm { get; set; }


        public string Issr { get; set; }

    }

}
