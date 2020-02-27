using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class FinancialInstitutionIdentification3
    {

        public string BIC { get; set; }

        public ClearingSystemMemberIdentification3Choice ClrSysMmbId { get; set; }

        public string Nm { get; set; }

        public PostalAddress PstlAdr { get; set; }

        public GenericIdentification3 PrtryId { get; set; }

    }

}
