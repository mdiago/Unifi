using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{

    public partial class PaymentTypeInformation2
    {
        public Priority2Code InstrPrty { get; set; }

        [XmlIgnore()]
        public bool InstrPrtySpecified { get; set; }

        [XmlElement("ClrChanl", typeof(ClearingChannel2Code))]
        [XmlElement("SvcLvl", typeof(ServiceLevel3Choice))]
        public object Item { get; set; }

        public CdOrPrtryTypeChoice LclInstrm { get; set; }

        public SequenceType1Code SeqTp { get; set; }

        [XmlIgnore()]
        public bool SeqTpSpecified { get; set; }


        public PaymentCategoryPurpose1Code CtgyPurp { get; set; }

        [XmlIgnore()]
        public bool CtgyPurpSpecified { get; set; }

    }

}
