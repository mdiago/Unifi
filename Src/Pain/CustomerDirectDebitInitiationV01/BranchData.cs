using System.Xml.Serialization;
using System;
using Unifi.Pain;


namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class BranchData
    {


        public string Id { get; set; }

        public string Nm { get; set; }

        public PostalAddress1 PstlAdr { get; set; }

    }

}
