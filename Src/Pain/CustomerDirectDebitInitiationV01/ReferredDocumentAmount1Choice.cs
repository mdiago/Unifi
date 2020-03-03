using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class ReferredDocumentAmount1Choice
    {

        [XmlElement("CdtNoteAmt", typeof(ActiveOrHistoricCurrencyAndAmount))]
        [XmlElement("DscntApldAmt", typeof(ActiveOrHistoricCurrencyAndAmount))]
        [XmlElement("DuePyblAmt", typeof(ActiveOrHistoricCurrencyAndAmount))]
        [XmlElement("RmtdAmt", typeof(ActiveOrHistoricCurrencyAndAmount))]
        [XmlElement("TaxAmt", typeof(ActiveOrHistoricCurrencyAndAmount))]
        [XmlChoiceIdentifier("ItemElementName")]
        public ActiveOrHistoricCurrencyAndAmount Item { get; set; }


        [XmlIgnore()]
        public ItemChoiceType5 ItemElementName { get; set; }

    }
}
