﻿using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class AccountIdentification4Choice
    {


        [XmlElement("IBAN", typeof(string))]
        [XmlElement("Othr", typeof(GenericAccountIdentification1))]
        public object Item { get; set; }

    }


}

