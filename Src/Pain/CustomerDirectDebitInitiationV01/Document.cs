using System.Xml.Serialization;
using System;
using Unifi.Pain;


namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    [XmlType(Namespace = Namespaces.V01)]
    [XmlRoot(Namespace = Namespaces.V01, IsNullable = false)]
    public partial class Document
    {


        [XmlElement("pain.008.001.01")]
        public pain00800101 pain00800101 { get; set; }

    }
}
