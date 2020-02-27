using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV04
{
    [XmlType(Namespace = Namespaces.V04)]
    [XmlRoot(Namespace = Namespaces.V04, IsNullable = false)]
    public partial class Document
    {
        public CustomerDirectDebitInitiationV04 CstmrDrctDbtInitn { get; set; }
    }


}

