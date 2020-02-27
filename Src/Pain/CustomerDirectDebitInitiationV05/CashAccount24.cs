using Unifi.Pain.CustomerDirectDebitInitiation;
using Unifi.Pain.CustomerDirectDebitInitiationV08;

namespace Unifi.Pain.CustomerDirectDebitInitiationV05
{
    public partial class CashAccount24
    {
        public AccountIdentificationChoice Id { get; set; }

        public CdOrPrtryTypeChoice Tp { get; set; }

        public string Ccy { get; set; }

        public string Nm { get; set; }

    }



}

