using System;
using System.Xml.Serialization;


namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class ReferredDocumentType2
    {

        public ReferredDocumentType1Choice CdOrPrtry { get; set; }

        public string Issr { get; set; }

    }

}
