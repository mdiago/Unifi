﻿using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class RemittanceLocation2
    {

    
        public string RmtId { get; set; }

        public RemittanceLocationMethod2Code RmtLctnMtd { get; set; }

        [XmlIgnore()]
        public bool RmtLctnMtdSpecified { get; set; }

        public string RmtLctnElctrncAdr { get; set; }

        public NameAndAddress10 RmtLctnPstlAdr { get; set; }

    }



}
