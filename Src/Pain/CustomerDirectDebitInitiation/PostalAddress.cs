using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// Representa una dirección postal.
    /// </summary>
    [Serializable()]
    public class PostalAddress
    {

        /// <summary>
        /// Tipo de dirección. Propieda válida de las versiones
        /// 1 a la 7. Para la versión 8 utilizar una instancia de
        /// la clase PostalAddressV08.
        /// </summary>
        [XmlElement("AdrTp", typeof(AddressTypeCode), Namespace = Namespaces.V02)]
        [XmlElement("AdrTp", typeof(AddressTypeChoice), Namespace = Namespaces.V08)]
        public virtual object AdrTp { get; set; }

        /// <summary>
        /// True si AdrTp especificado.
        /// </summary>
        [XmlIgnore()]
        public bool AdrTpCodeSpecified { get; set; }
  

        /// <summary>
        /// Departmento. Valor válido a partir de la
        /// versión 2.
        /// </summary>
        public string Dept { get; set; }

        /// <summary>
        /// SubDepartmento. Valor válido a partir de la versión 2.
        /// </summary>
        public string SubDept { get; set; }

        /// <summary>
        /// StreetName. Nombre de la vía: calle, avenida, plaza...
        /// Max70Text. Todas las versiones.
        /// </summary> 
        public string StrtNm { get; set; }

        /// <summary>
        /// BuildingNumber. Número que identifica la posición 
        /// de una construcción en una vía.
        /// Max16Text.  Todas las versiones.
        /// </summary>
        public string BldgNb { get; set; }

        /// <summary>
        /// BuildingName. Nombre del edificio o casa. Válido a partir de la versión 8.
        /// </summary>
        public string BldgNm { get; set; }

        /// <summary>
        /// Piso de un edificio o casa. Válido a partir de la versión 8.
        /// </summary>
        public string Flr { get; set; }

        /// <summary>
        /// Número de apartado de correos en una oficna postal asignado a una
        /// persona u organización dónde se deposita la correspondencia para la misma.
        /// Max16Text.  Válido a partir de la versión 8.
        /// </summary>
        public string PstBx { get; set; }

        /// <summary>
        /// Número de viviedna, oficna, entresuelo, local...  Válido a partir de la versión 8.
        /// </summary>
        public string Room { get; set; }

        /// <summary>
        /// Código postal. Max16Text.  Todas las versiones.
        /// </summary>
        public string PstCd { get; set; }

        /// <summary>
        /// Nombre ciudad. Max35Text. Todas las versiones.
        /// </summary>
        public string TwnNm { get; set; }

        /// <summary>
        /// Nombre distrito o barrio de una ciudad. Max35Text.  Válido a partir de la versión 8.
        /// </summary>
        public string TwnLctnNm { get; set; }

        /// <summary>
        /// Identifica una subdivisión de una subdivisión de país.
        /// Por ejemplo (España > Comunidad Valencia > Castellón).
        /// Max35Text.  Válido a partir de la versión 8.
        /// </summary>
        public string DstrctNm { get; set; }

        /// <summary>
        /// Subdivisión de un país (España > Comunidad Valenciana) . Max35Text. Todas las versiones.
        /// </summary>
        public string CtrySubDvsn { get; set; }

        /// <summary>
        /// Código pais ISO 3166 Alpha-2. Todas las versiones.
        /// </summary>
        public string Ctry { get; set; }

        /// <summary>
        /// Colección de líneas con iformación para localizar e identificar
        /// una dirección especifica, atendiendo a las especificaciones establecidas
        /// por los servicios postales. Max70Text
        /// </summary>
        [XmlElement("AdrLine")]
        public string[] AdrLine { get; set; }

    }
}
