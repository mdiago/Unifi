using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class DocumentAdjustment1
    {


        public ActiveOrHistoricCurrencyAndAmount Amt { get; set; }

        public CreditDebitCode CdtDbtInd { get; set; }

        [XmlIgnore()]
        public bool CdtDbtIndSpecified { get; set; }

        public string Rsn { get; set; }

        public string AddtlInf { get; set; }

    }

}
