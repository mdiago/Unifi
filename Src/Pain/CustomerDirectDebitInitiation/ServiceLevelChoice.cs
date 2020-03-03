using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    /// <summary>
    /// Specifies the service level of the transaction.
    /// </summary>
    public partial class ServiceLevelChoice
    {

        /// <summary>
        /// Identification of a pre-agreed level of service between the parties in a coded form.
        /// Proprietary identification of a pre-agreed level of service between the parties.
        /// </summary>
        [XmlElement("Cd", typeof(ServiceLevelCode))]
        [XmlElement("Prtry", typeof(string))]
        public object Item { get; set; }

    }

}
