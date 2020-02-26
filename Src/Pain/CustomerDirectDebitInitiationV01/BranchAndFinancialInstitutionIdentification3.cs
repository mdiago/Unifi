using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class BranchAndFinancialInstitutionIdentification3
    {

        public FinancialInstitutionIdentification5Choice FinInstnId { get; set; }

        public BranchData BrnchId { get; set; }

    }

}
