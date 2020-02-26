using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class TaxInformation3
    {

        public TaxParty1 Cdtr { get; set; }


        public TaxParty2 Dbtr { get; set; }

        public string AdmstnZn { get; set; }


        public string RefNb { get; set; }


        public string Mtd { get; set; }

        public ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt { get; set; }

        public ActiveOrHistoricCurrencyAndAmount TtlTaxAmt { get; set; }


        [XmlElement(DataType = "date")]
        public DateTime Dt { get; set; }


        [XmlIgnore()]
        public bool DtSpecified { get; set; }

        public decimal SeqNb { get; set; }


        [XmlIgnore()]
        public bool SeqNbSpecified { get; set; }


        [XmlElement("Rcrd")]
        public TaxRecord1[] Rcrd { get; set; }

    }


}

