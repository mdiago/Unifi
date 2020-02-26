using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class TaxInformation2
    {

        public string CdtrTaxId { get; set; }

        public string CdtrTaxTp { get; set; }

        public string DbtrTaxId { get; set; }

        public string TaxRefNb { get; set; }

        public CurrencyAndAmount TtlTaxblBaseAmt { get; set; }

        public CurrencyAndAmount TtlTaxAmt { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime TaxDt { get; set; }

        [XmlIgnore()]
        public bool TaxDtSpecified { get; set; }


        [XmlElement("TaxTpInf")]
        public TaxDetails[] TaxTpInf { get; set; }

    }
}
