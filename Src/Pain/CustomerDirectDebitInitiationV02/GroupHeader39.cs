using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class GroupHeader39
    {

        public string MsgId { get; set; }

        public DateTime CreDtTm { get; set; }

        [XmlElement("Authstn")]
        public Authorisation1Choice[] Authstn { get; set; }

        public string NbOfTxs { get; set; }

        public decimal CtrlSum { get; set; }

        [XmlIgnore()]
        public bool CtrlSumSpecified { get; set; }

        public PartyIdentification32 InitgPty { get; set; }

        public BranchAndFinancialInstitutionIdentification4 FwdgAgt { get; set; }

    }

}
