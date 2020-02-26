using System.Xml.Serialization;
namespace Unifi.Pain.CustomerDirectDebitInitiationV03
{
    public partial class RemittanceAmount2
    {

        private ActiveOrHistoricCurrencyAndAmount duePyblAmtField;

        private DiscountAmountAndType1[] dscntApldAmtField;

        private ActiveOrHistoricCurrencyAndAmount cdtNoteAmtField;

        private TaxAmountAndType1[] taxAmtField;

        private DocumentAdjustment1[] adjstmntAmtAndRsnField;

        private ActiveOrHistoricCurrencyAndAmount rmtdAmtField;

    
        public ActiveOrHistoricCurrencyAndAmount DuePyblAmt { get; set; }

        [XmlElement("DscntApldAmt")]
        public DiscountAmountAndType1[] DscntApldAmt { get; set; }

        public ActiveOrHistoricCurrencyAndAmount CdtNoteAmt { get; set; }

        [XmlElement("TaxAmt")]
        public TaxAmountAndType1[] TaxAmt { get; set; }


        [XmlElement("AdjstmntAmtAndRsn")]
        public DocumentAdjustment1[] AdjstmntAmtAndRsn { get; set; }

        public ActiveOrHistoricCurrencyAndAmount RmtdAmt { get; set; }

    }



}

