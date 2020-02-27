using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class PaymentTypeInformation20
    {

        public Priority2Code InstrPrty { get; set; }

        [XmlIgnore()]
        public bool InstrPrtySpecified { get; set; }

        public CdOrPrtryTypeChoice SvcLvl { get; set; }

        public CdOrPrtryTypeChoice LclInstrm { get; set; }

        public SequenceType1Code SeqTp { get; set; }   

        [XmlIgnore()]
        public bool SeqTpSpecified { get; set; }

        public CdOrPrtryTypeChoice CtgyPurp { get; set; }

    }


}

