using System.Xml.Serialization;
using System;
using Unifi.Pain;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class AmendmentInformationDetails1
    {


        public string OrgnlMndtId { get; set; }

        public PartyIdentification OrgnlCdtrSchmeId { get; set; }

        public BranchAndFinancialInstitutionIdentification3 OrgnlCdtrAgt { get; set; }

        public CashAccount7 OrgnlCdtrAgtAcct { get; set; }

        public PartyIdentification OrgnlDbtr { get; set; }

        public CashAccount7 OrgnlDbtrAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification3 OrgnlDbtrAgt { get; set; }

        public CashAccount7 OrgnlDbtrAgtAcct { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime OrgnlFnlColltnDt { get; set; }

        [XmlIgnore()]
        public bool OrgnlFnlColltnDtSpecified { get; set; }

        public Frequency1Code OrgnlFrqcy { get; set; }

        [XmlIgnore()]
        public bool OrgnlFrqcySpecified { get; set; }

    }

}
