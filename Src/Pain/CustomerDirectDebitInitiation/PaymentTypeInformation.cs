using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    [Serializable()]
    public partial class PaymentTypeInformation
    {
        public PriorityCode InstrPrty { get; set; }

        [XmlIgnore()]
        public bool InstrPrtySpecified { get; set; }

        /// <summary>
        /// Sólo válido en la versión 1.
        /// </summary>
        public ClearingChannelCode ClrChanl { get; set; }

        public CdOrPrtryTypeChoice SvcLvl { get; set; }

        public CdOrPrtryTypeChoice LclInstrm { get; set; }

        public SequenceTypeCode SeqTp { get; set; }

        [XmlIgnore()]
        public bool SeqTpSpecified { get; set; }

        [XmlElement("CtgyPurp", typeof(PaymentCategoryPurposeCode), Namespace = Namespaces.V02)]
        [XmlElement("CtgyPurp", typeof(CdOrPrtryTypeChoice), Namespace = Namespaces.V08)]
        public virtual object CtgyPurp { get; set; }

        [XmlIgnore()]
        public bool CtgyPurpSpecified { get; set; }

    }

}
