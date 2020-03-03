using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV06
{
    public partial class RemittanceAmount2
    {

        
        public ActiveOrHistoricCurrencyAndAmount DuePyblAmt { get; set; }

        [XmlElement("DscntApldAmt")]
        public DiscountAmountAndType1[] DscntApldAmt { get; set; }

        public ActiveOrHistoricCurrencyAndAmount CdtNoteAmt { get; set; }


        [XmlElement("TaxAmt")]
        public TaxAmountAndType[] TaxAmt { get; set; }

        [XmlElement("AdjstmntAmtAndRsn")]
        public DocumentAdjustment1[] AdjstmntAmtAndRsn { get; set; }

        public ActiveOrHistoricCurrencyAndAmount RmtdAmt { get; set; }

    }



}

