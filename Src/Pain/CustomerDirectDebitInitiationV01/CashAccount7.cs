using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{

    public partial class CashAccount7
    {


        public AccountIdentificationChoice Id { get; set; }


        public CashAccountType2 Tp { get; set; }


        public string Ccy { get; set; }


        public string Nm { get; set; }

    }

}
