using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    [XmlType(Namespace = Namespaces.V07)]
    [XmlRoot(Namespace = Namespaces.V07, IsNullable = false)]
    public partial class Document
    {
        
        public CustomerDirectDebitInitiationV07 CstmrDrctDbtInitn { get; set; }

    }


}

