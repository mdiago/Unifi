using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    [XmlType(Namespace = Namespaces.V03)]
    [XmlRoot(Namespace = Namespaces.V03, IsNullable = false)]
    public partial class Document
    {
    
        public CustomerDirectDebitInitiationV03 CstmrDrctDbtInitn { get; set; }

    }



}

