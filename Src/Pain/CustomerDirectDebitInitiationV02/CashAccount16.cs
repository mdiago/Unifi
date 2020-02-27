using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class CashAccount16
    {

        public AccountIdentificationChoice Id { get; set; }
        public CashAccountType2 Tp { get; set; }

        public string Ccy { get; set; }

        public string Nm { get; set; }

    }


}

