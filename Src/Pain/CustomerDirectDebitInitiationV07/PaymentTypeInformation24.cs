using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    public partial class PaymentTypeInformation
    {

      
        
        public PriorityCode InstrPrty { get; set; }

        [XmlIgnore()]
        public bool InstrPrtySpecified { get; set; }

        public CdOrPrtryTypeChoice SvcLvl { get; set; }

        public CdOrPrtryTypeChoice LclInstrm { get; set; }

        public SequenceTypeCode SeqTp { get; set; }

        [XmlIgnore()]
        public bool SeqTpSpecified { get; set; }

        public CdOrPrtryTypeChoice CtgyPurp { get; set; }

    }


}

