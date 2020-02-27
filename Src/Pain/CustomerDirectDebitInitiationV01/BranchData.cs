using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class BranchData
    {


        public string Id { get; set; }

        public string Nm { get; set; }

        public PostalAddress PstlAdr { get; set; }

    }

}
