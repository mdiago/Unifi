﻿using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class GroupHeader1
    {

        public string MsgId { get; set; }


        public DateTime CreDtTm { get; set; }


        [XmlElement("Authstn")]
        public string[] Authstn { get; set; }


        public bool BtchBookg { get; set; }


        [XmlIgnore()]
        public bool BtchBookgSpecified { get; set; }


        public string NbOfTxs { get; set; }


        public decimal CtrlSum { get; set; }


        [XmlIgnore()]
        public bool CtrlSumSpecified { get; set; }


        public Grouping1Code Grpg { get; set; }


        public PartyIdentification8 InitgPty { get; set; }


        public BranchAndFinancialInstitutionIdentification3 FwdgAgt { get; set; }


    }
}