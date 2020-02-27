using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV06
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

