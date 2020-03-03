using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;
using Unifi.Pain.CustomerDirectDebitInitiationV02;

namespace Unifi.Pain.CustomerDirectDebitInitiationV04
{
    public partial class GroupHeader55
    {
        public string MsgId { get; set; }


        public System.DateTime CreDtTm { get; set; }


        [XmlElement("Authstn")]
        public Authorisation1Choice[] Authstn { get; set; }


        public string NbOfTxs { get; set; }


        public decimal CtrlSum { get; set; }


        [XmlIgnore()]
        public bool CtrlSumSpecified { get; set; }


        public PartyIdentification InitgPty { get; set; }


        public BranchAndFinancialInstitutionIdentification FwdgAgt { get; set; }
    }


}

