using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class PaymentTypeInformation24
    {

    
        public Priority2Code InstrPrty { get; set; }

        [XmlIgnore()]
        public bool InstrPrtySpecified { get; set; }

        public ServiceLevel8Choice SvcLvl { get; set; }

        public LocalInstrument2Choice LclInstrm { get; set; }

        public SequenceType3Code SeqTp { get; set; }

        [XmlIgnore()]
        public bool SeqTpSpecified { get; set; }

        public CategoryPurpose1Choice CtgyPurp { get; set; }

    }



}

