using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    [Serializable()]
    public partial class BranchAndFinancialInstitutionIdentification
    {

        /// <summary>
        /// FinancialInstitutionIdentificationChoice Sólo versión 1. 
        /// Unique and unambiguous identification of a financial institution,
        /// as assigned under an internationally recognised or proprietary identification scheme.
        /// </summary>
        public FinancialInstitutionIdentification FinInstnId { get; set; }

        /// <summary>
        /// Identifies a specific branch of a financial institution.
        /// Usage: This component should be used in case the identification information
        /// in the financial institution component does not provide identification up
        /// to branch level.
        /// </summary>
        public BranchData BrnchId { get; set; }

    }

}
