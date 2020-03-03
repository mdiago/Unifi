using System;
using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;
using Unifi.Pain.CustomerDirectDebitInitiationV02;
using Unifi.Pain.CustomerDirectDebitInitiationV03;

namespace Unifi.Pain.CustomerDirectDebitInitiationV07
{
    public partial class PaymentInstruction21
    {

        
        public string PmtInfId { get; set; }

        public PaymentMethodCode PmtMtd { get; set; }

        public bool BtchBookg { get; set; }

        [XmlIgnore()]
        public bool BtchBookgSpecified { get; set; }

        public string NbOfTxs { get; set; }

        public decimal CtrlSum { get; set; }

        [XmlIgnore()]
        public bool CtrlSumSpecified { get; set; }

        public PaymentTypeInformation PmtTpInf { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime ReqdColltnDt { get; set; }

        public PartyIdentification Cdtr { get; set; }

        public CashAccount CdtrAcct { get; set; }


        public BranchAndFinancialInstitutionIdentification CdtrAgt { get; set; }


        public CashAccount CdtrAgtAcct { get; set; }

        public PartyIdentification UltmtCdtr { get; set; }

        public ChargeBearerTypeCode ChrgBr { get; set; }

        [XmlIgnore()]
        public bool ChrgBrSpecified { get; set; }

        public CashAccount ChrgsAcct { get; set; }

        public BranchAndFinancialInstitutionIdentification ChrgsAcctAgt { get; set; }

        public PartyIdentification CdtrSchmeId { get; set; }

        [XmlElement("DrctDbtTxInf")]
        public DirectDebitTransactionInformation22[] DrctDbtTxInf { get; set; }

    }


}

