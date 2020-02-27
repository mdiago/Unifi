using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    public partial class CashAccount24
    {

        public AccountIdentificationChoice Id { get; set; }

        public CdOrPrtryTypeChoice Tp { get; set; }

        public string Ccy { get; set; }

        public string Nm { get; set; }

    }


}

