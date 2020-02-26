using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class ReferredDocumentAmount1Choice
    {

        [XmlElement("CdtNoteAmt", typeof(CurrencyAndAmount))]
        [XmlElement("DscntApldAmt", typeof(CurrencyAndAmount))]
        [XmlElement("DuePyblAmt", typeof(CurrencyAndAmount))]
        [XmlElement("RmtdAmt", typeof(CurrencyAndAmount))]
        [XmlElement("TaxAmt", typeof(CurrencyAndAmount))]
        [XmlChoiceIdentifier("ItemElementName")]
        public CurrencyAndAmount Item { get; set; }


        [XmlIgnore()]
        public ItemChoiceType5 ItemElementName { get; set; }

    }
}
