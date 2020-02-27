using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV04
{
    public partial class PaymentTypeInformation24
    {
        public Priority2Code InstrPrty { get; set; }


        [XmlIgnore()]
        public bool InstrPrtySpecified { get; set; }


        public CdOrPrtryTypeChoice SvcLvl { get; set; }


        public CdOrPrtryTypeChoice LclInstrm { get; set; }


        public SequenceType3Code SeqTp { get; set; }


        [XmlIgnore()]
        public bool SeqTpSpecified { get; set; }


        public CdOrPrtryTypeChoice CtgyPurp { get; set; }
    }


}

