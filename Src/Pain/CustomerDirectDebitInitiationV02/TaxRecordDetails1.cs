using System;
using System.Xml.Serialization;


namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class TaxRecordDetails1
    {

        public TaxPeriod1 Prd { get; set; }

        public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

    }

}
