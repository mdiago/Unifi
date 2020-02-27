using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV02
{
    public partial class FinancialInstitutionIdentification7
    {

        public string BIC { get; set; }

        public ClearingSystemMemberIdentification2 ClrSysMmbId { get; set; }

        public string Nm { get; set; }

        public PostalAddress PstlAdr { get; set; }

        public GenericIdentificationCdOrPrtry Othr { get; set; }

    }


}

