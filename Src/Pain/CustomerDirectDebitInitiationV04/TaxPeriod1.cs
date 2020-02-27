using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV04
{
    public partial class TaxPeriod1
    {

        [XmlElement(DataType = "date")]
        public System.DateTime Yr { get; set; }


        [XmlIgnore()]
        public bool YrSpecified { get; set; }


        public TaxRecordPeriod1Code Tp { get; set; }


        [XmlIgnore()]
        public bool TpSpecified { get; set; }


        public DatePeriodDetails FrToDt { get; set; }
    }


}

