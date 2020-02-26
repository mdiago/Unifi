using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    [XmlType(Namespace = Namespaces.V02)]
    [XmlRoot(Namespace = Namespaces.V02, IsNullable = false)]
    public partial class Document
    {

        public CustomerDirectDebitInitiationV02 CstmrDrctDbtInitn { get; set; }
    }

}
