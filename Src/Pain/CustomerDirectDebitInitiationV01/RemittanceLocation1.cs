using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class RemittanceLocation1
    {
        public string RmtId { get; set; }

        public RemittanceLocationMethod1Code RmtLctnMtd { get; set; }


        [XmlIgnore()]
        public bool RmtLctnMtdSpecified { get; set; }


        public string RmtLctnElctrncAdr { get; set; }


        public NameAndAddress RmtLctnPstlAdr { get; set; }

    }

}
