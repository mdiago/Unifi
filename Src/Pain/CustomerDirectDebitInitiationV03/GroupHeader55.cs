using System;
using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class GroupHeader55
    {

        public string MsgId { get; set; }

        public DateTime CreDtTm { get; set; }

        [XmlElement("Authstn")]
        public Authorisation1Choice[] Authstn { get; set; }

        public string NbOfTxs { get; set; }

        public decimal CtrlSum { get; set; }

        [XmlIgnore()]
        public bool CtrlSumSpecified { get; set; }

        public PartyIdentification InitgPty { get; set; }

        public BranchAndFinancialInstitutionIdentification5 FwdgAgt { get; set; }

    }



}

