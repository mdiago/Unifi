using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    [Serializable()]
    public partial class NameAndAddress
    {

        public string Nm { get; set; }


        public PostalAddress PstlAdr { get; set; }

    }

}
