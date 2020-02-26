using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class RemittanceAmount1
    {

        public ActiveOrHistoricCurrencyAndAmount DuePyblAmt { get; set; }

        public ActiveOrHistoricCurrencyAndAmount DscntApldAmt { get; set; }

        public ActiveOrHistoricCurrencyAndAmount CdtNoteAmt { get; set; }

        public ActiveOrHistoricCurrencyAndAmount TaxAmt { get; set; }

        [XmlElement("AdjstmntAmtAndRsn")]
        public DocumentAdjustment1[] AdjstmntAmtAndRsn { get; set; }

        public ActiveOrHistoricCurrencyAndAmount RmtdAmt { get; set; }

    }

}
