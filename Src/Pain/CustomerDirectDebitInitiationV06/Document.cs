using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV06
{
    [XmlType(Namespace = Namespaces.V06)]
    [XmlRoot(Namespace = Namespaces.V06, IsNullable = false)]
    public partial class Document
    {

        private CustomerDirectDebitInitiationV06 cstmrDrctDbtInitnField;

        
        public CustomerDirectDebitInitiationV06 CstmrDrctDbtInitn { get; set; }

    }



}

