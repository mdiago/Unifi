using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV05
{
    [XmlType(Namespace = Namespaces.V05)]
    [XmlRoot(Namespace = Namespaces.V05, IsNullable = false)]
    public partial class Document
    {

        public CustomerDirectDebitInitiationV05 CstmrDrctDbtInitn { get; set; }

    }



}

