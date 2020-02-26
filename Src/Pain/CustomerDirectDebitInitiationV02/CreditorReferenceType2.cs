using System;
using System.Xml.Serialization;


namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class CreditorReferenceType2
    {

        public CreditorReferenceType1Choice CdOrPrtry { get; set; }

        public string Issr { get; set; }

    }

}
