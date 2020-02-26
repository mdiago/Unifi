using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV04
{


    



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    [XmlRoot(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IsNullable = false)]
    public partial class Document
    {

        private CustomerDirectDebitInitiationV04 cstmrDrctDbtInitnField;

       
        public CustomerDirectDebitInitiationV04 CstmrDrctDbtInitn
        {
            get
            {
                return this.cstmrDrctDbtInitnField;
            }
            set
            {
                this.cstmrDrctDbtInitnField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class CustomerDirectDebitInitiationV04
    {

        private GroupHeader55 grpHdrField;

        private PaymentInstruction10[] pmtInfField;

        private SupplementaryData1[] splmtryDataField;

       
        public GroupHeader55 GrpHdr
        {
            get
            {
                return this.grpHdrField;
            }
            set
            {
                this.grpHdrField = value;
            }
        }

       
        [XmlElement("PmtInf")]
        public PaymentInstruction10[] PmtInf
        {
            get
            {
                return this.pmtInfField;
            }
            set
            {
                this.pmtInfField = value;
            }
        }

       
        [XmlElement("SplmtryData")]
        public SupplementaryData1[] SplmtryData
        {
            get
            {
                return this.splmtryDataField;
            }
            set
            {
                this.splmtryDataField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class GroupHeader55
    {

        private string msgIdField;

        private System.DateTime creDtTmField;

        private Authorisation1Choice[] authstnField;

        private string nbOfTxsField;

        private decimal ctrlSumField;

        private bool ctrlSumFieldSpecified;

        private PartyIdentification43 initgPtyField;

        private BranchAndFinancialInstitutionIdentification5 fwdgAgtField;

       
        public string MsgId
        {
            get
            {
                return this.msgIdField;
            }
            set
            {
                this.msgIdField = value;
            }
        }

       
        public System.DateTime CreDtTm
        {
            get
            {
                return this.creDtTmField;
            }
            set
            {
                this.creDtTmField = value;
            }
        }

       
        [XmlElement("Authstn")]
        public Authorisation1Choice[] Authstn
        {
            get
            {
                return this.authstnField;
            }
            set
            {
                this.authstnField = value;
            }
        }

       
        public string NbOfTxs
        {
            get
            {
                return this.nbOfTxsField;
            }
            set
            {
                this.nbOfTxsField = value;
            }
        }

       
        public decimal CtrlSum
        {
            get
            {
                return this.ctrlSumField;
            }
            set
            {
                this.ctrlSumField = value;
            }
        }

       
        [XmlIgnore()]
        public bool CtrlSumSpecified
        {
            get
            {
                return this.ctrlSumFieldSpecified;
            }
            set
            {
                this.ctrlSumFieldSpecified = value;
            }
        }

       
        public PartyIdentification43 InitgPty
        {
            get
            {
                return this.initgPtyField;
            }
            set
            {
                this.initgPtyField = value;
            }
        }

       
        public BranchAndFinancialInstitutionIdentification5 FwdgAgt
        {
            get
            {
                return this.fwdgAgtField;
            }
            set
            {
                this.fwdgAgtField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class Authorisation1Choice
    {

        private object itemField;

       
        [XmlElement("Cd", typeof(Authorisation1Code))]
        [XmlElement("Prtry", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public enum Authorisation1Code
    {

       
        AUTH,

       
        FDET,

       
        FSUM,

       
        ILEV,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class SupplementaryData1
    {

        private string plcAndNmField;

        private System.Xml.XmlElement envlpField;

       
        public string PlcAndNm
        {
            get
            {
                return this.plcAndNmField;
            }
            set
            {
                this.plcAndNmField = value;
            }
        }

       
        public System.Xml.XmlElement Envlp
        {
            get
            {
                return this.envlpField;
            }
            set
            {
                this.envlpField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class CreditorReferenceType1Choice
    {

        private object itemField;

       
        [XmlElement("Cd", typeof(DocumentType3Code))]
        [XmlElement("Prtry", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public enum DocumentType3Code
    {

       
        RADM,

       
        RPIN,

       
        FXDR,

       
        DISP,

       
        PUOR,

       
        SCOR,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class CreditorReferenceType2
    {

        private CreditorReferenceType1Choice cdOrPrtryField;

        private string issrField;

       
        public CreditorReferenceType1Choice CdOrPrtry
        {
            get
            {
                return this.cdOrPrtryField;
            }
            set
            {
                this.cdOrPrtryField = value;
            }
        }

       
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class CreditorReferenceInformation2
    {

        private CreditorReferenceType2 tpField;

        private string refField;

       
        public CreditorReferenceType2 Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

       
        public string Ref
        {
            get
            {
                return this.refField;
            }
            set
            {
                this.refField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class DocumentAdjustment1
    {

        private ActiveOrHistoricCurrencyAndAmount amtField;

        private CreditDebitCode cdtDbtIndField;

        private bool cdtDbtIndFieldSpecified;

        private string rsnField;

        private string addtlInfField;

       
        public ActiveOrHistoricCurrencyAndAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }

       
        public CreditDebitCode CdtDbtInd
        {
            get
            {
                return this.cdtDbtIndField;
            }
            set
            {
                this.cdtDbtIndField = value;
            }
        }

       
        [XmlIgnore()]
        public bool CdtDbtIndSpecified
        {
            get
            {
                return this.cdtDbtIndFieldSpecified;
            }
            set
            {
                this.cdtDbtIndFieldSpecified = value;
            }
        }

       
        public string Rsn
        {
            get
            {
                return this.rsnField;
            }
            set
            {
                this.rsnField = value;
            }
        }

       
        public string AddtlInf
        {
            get
            {
                return this.addtlInfField;
            }
            set
            {
                this.addtlInfField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class ActiveOrHistoricCurrencyAndAmount
    {

        private string ccyField;

        private decimal valueField;

       
        [XmlAttribute()]
        public string Ccy
        {
            get
            {
                return this.ccyField;
            }
            set
            {
                this.ccyField = value;
            }
        }

       
        [XmlText()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public enum CreditDebitCode
    {

       
        CRDT,

       
        DBIT,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class TaxAmountType1Choice
    {

        private string itemField;

        private ItemChoiceType11 itemElementNameField;

       
        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

       
        [XmlIgnore()]
        public ItemChoiceType11 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IncludeInSchema = false)]
    public enum ItemChoiceType11
    {

       
        Cd,

       
        Prtry,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class TaxAmountAndType1
    {

        private TaxAmountType1Choice tpField;

        private ActiveOrHistoricCurrencyAndAmount amtField;

       
        public TaxAmountType1Choice Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

       
        public ActiveOrHistoricCurrencyAndAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class DiscountAmountType1Choice
    {

        private string itemField;

        private ItemChoiceType10 itemElementNameField;

       
        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

       
        [XmlIgnore()]
        public ItemChoiceType10 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IncludeInSchema = false)]
    public enum ItemChoiceType10
    {

       
        Cd,

       
        Prtry,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class DiscountAmountAndType1
    {

        private DiscountAmountType1Choice tpField;

        private ActiveOrHistoricCurrencyAndAmount amtField;

       
        public DiscountAmountType1Choice Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

       
        public ActiveOrHistoricCurrencyAndAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class RemittanceAmount2
    {

        private ActiveOrHistoricCurrencyAndAmount duePyblAmtField;

        private DiscountAmountAndType1[] dscntApldAmtField;

        private ActiveOrHistoricCurrencyAndAmount cdtNoteAmtField;

        private TaxAmountAndType1[] taxAmtField;

        private DocumentAdjustment1[] adjstmntAmtAndRsnField;

        private ActiveOrHistoricCurrencyAndAmount rmtdAmtField;

       
        public ActiveOrHistoricCurrencyAndAmount DuePyblAmt
        {
            get
            {
                return this.duePyblAmtField;
            }
            set
            {
                this.duePyblAmtField = value;
            }
        }

       
        [XmlElement("DscntApldAmt")]
        public DiscountAmountAndType1[] DscntApldAmt
        {
            get
            {
                return this.dscntApldAmtField;
            }
            set
            {
                this.dscntApldAmtField = value;
            }
        }

       
        public ActiveOrHistoricCurrencyAndAmount CdtNoteAmt
        {
            get
            {
                return this.cdtNoteAmtField;
            }
            set
            {
                this.cdtNoteAmtField = value;
            }
        }

       
        [XmlElement("TaxAmt")]
        public TaxAmountAndType1[] TaxAmt
        {
            get
            {
                return this.taxAmtField;
            }
            set
            {
                this.taxAmtField = value;
            }
        }

       
        [XmlElement("AdjstmntAmtAndRsn")]
        public DocumentAdjustment1[] AdjstmntAmtAndRsn
        {
            get
            {
                return this.adjstmntAmtAndRsnField;
            }
            set
            {
                this.adjstmntAmtAndRsnField = value;
            }
        }

       
        public ActiveOrHistoricCurrencyAndAmount RmtdAmt
        {
            get
            {
                return this.rmtdAmtField;
            }
            set
            {
                this.rmtdAmtField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class ReferredDocumentType1Choice
    {

        private object itemField;

       
        [XmlElement("Cd", typeof(DocumentType5Code))]
        [XmlElement("Prtry", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public enum DocumentType5Code
    {

       
        MSIN,

       
        CNFA,

       
        DNFA,

       
        CINV,

       
        CREN,

       
        DEBN,

       
        HIRI,

       
        SBIN,

       
        CMCN,

       
        SOAC,

       
        DISP,

       
        BOLD,

       
        VCHR,

       
        AROI,

       
        TSUT,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class ReferredDocumentType2
    {

        private ReferredDocumentType1Choice cdOrPrtryField;

        private string issrField;

       
        public ReferredDocumentType1Choice CdOrPrtry
        {
            get
            {
                return this.cdOrPrtryField;
            }
            set
            {
                this.cdOrPrtryField = value;
            }
        }

       
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class ReferredDocumentInformation3
    {

        private ReferredDocumentType2 tpField;

        private string nbField;

        private System.DateTime rltdDtField;

        private bool rltdDtFieldSpecified;

       
        public ReferredDocumentType2 Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

       
        public string Nb
        {
            get
            {
                return this.nbField;
            }
            set
            {
                this.nbField = value;
            }
        }

       
        [XmlElement(DataType = "date")]
        public System.DateTime RltdDt
        {
            get
            {
                return this.rltdDtField;
            }
            set
            {
                this.rltdDtField = value;
            }
        }

       
        [XmlIgnore()]
        public bool RltdDtSpecified
        {
            get
            {
                return this.rltdDtFieldSpecified;
            }
            set
            {
                this.rltdDtFieldSpecified = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class StructuredRemittanceInformation9
    {

        private ReferredDocumentInformation3[] rfrdDocInfField;

        private RemittanceAmount2 rfrdDocAmtField;

        private CreditorReferenceInformation2 cdtrRefInfField;

        private PartyIdentification43 invcrField;

        private PartyIdentification43 invceeField;

        private string[] addtlRmtInfField;

       
        [XmlElement("RfrdDocInf")]
        public ReferredDocumentInformation3[] RfrdDocInf
        {
            get
            {
                return this.rfrdDocInfField;
            }
            set
            {
                this.rfrdDocInfField = value;
            }
        }

       
        public RemittanceAmount2 RfrdDocAmt
        {
            get
            {
                return this.rfrdDocAmtField;
            }
            set
            {
                this.rfrdDocAmtField = value;
            }
        }

       
        public CreditorReferenceInformation2 CdtrRefInf
        {
            get
            {
                return this.cdtrRefInfField;
            }
            set
            {
                this.cdtrRefInfField = value;
            }
        }

       
        public PartyIdentification43 Invcr
        {
            get
            {
                return this.invcrField;
            }
            set
            {
                this.invcrField = value;
            }
        }

       
        public PartyIdentification43 Invcee
        {
            get
            {
                return this.invceeField;
            }
            set
            {
                this.invceeField = value;
            }
        }

       
        [XmlElement("AddtlRmtInf")]
        public string[] AddtlRmtInf
        {
            get
            {
                return this.addtlRmtInfField;
            }
            set
            {
                this.addtlRmtInfField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class PartyIdentification43
    {

        private string nmField;

        private PostalAddress6 pstlAdrField;

        private Party11Choice idField;

        private string ctryOfResField;

        private ContactDetails2 ctctDtlsField;

       
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

       
        public PostalAddress6 PstlAdr
        {
            get
            {
                return this.pstlAdrField;
            }
            set
            {
                this.pstlAdrField = value;
            }
        }

       
        public Party11Choice Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

       
        public string CtryOfRes
        {
            get
            {
                return this.ctryOfResField;
            }
            set
            {
                this.ctryOfResField = value;
            }
        }

       
        public ContactDetails2 CtctDtls
        {
            get
            {
                return this.ctctDtlsField;
            }
            set
            {
                this.ctctDtlsField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class PostalAddress6
    {

        private AddressType2Code adrTpField;

        private bool adrTpFieldSpecified;

        private string deptField;

        private string subDeptField;

        private string strtNmField;

        private string bldgNbField;

        private string pstCdField;

        private string twnNmField;

        private string ctrySubDvsnField;

        private string ctryField;

        private string[] adrLineField;

       
        public AddressType2Code AdrTp
        {
            get
            {
                return this.adrTpField;
            }
            set
            {
                this.adrTpField = value;
            }
        }

       
        [XmlIgnore()]
        public bool AdrTpSpecified
        {
            get
            {
                return this.adrTpFieldSpecified;
            }
            set
            {
                this.adrTpFieldSpecified = value;
            }
        }

       
        public string Dept
        {
            get
            {
                return this.deptField;
            }
            set
            {
                this.deptField = value;
            }
        }

       
        public string SubDept
        {
            get
            {
                return this.subDeptField;
            }
            set
            {
                this.subDeptField = value;
            }
        }

       
        public string StrtNm
        {
            get
            {
                return this.strtNmField;
            }
            set
            {
                this.strtNmField = value;
            }
        }

       
        public string BldgNb
        {
            get
            {
                return this.bldgNbField;
            }
            set
            {
                this.bldgNbField = value;
            }
        }

       
        public string PstCd
        {
            get
            {
                return this.pstCdField;
            }
            set
            {
                this.pstCdField = value;
            }
        }

       
        public string TwnNm
        {
            get
            {
                return this.twnNmField;
            }
            set
            {
                this.twnNmField = value;
            }
        }

       
        public string CtrySubDvsn
        {
            get
            {
                return this.ctrySubDvsnField;
            }
            set
            {
                this.ctrySubDvsnField = value;
            }
        }

       
        public string Ctry
        {
            get
            {
                return this.ctryField;
            }
            set
            {
                this.ctryField = value;
            }
        }

       
        [XmlElement("AdrLine")]
        public string[] AdrLine
        {
            get
            {
                return this.adrLineField;
            }
            set
            {
                this.adrLineField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public enum AddressType2Code
    {

       
        ADDR,

       
        PBOX,

       
        HOME,

       
        BIZZ,

       
        MLTO,

       
        DLVY,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class Party11Choice
    {

        private object itemField;

       
        [XmlElement("OrgId", typeof(OrganisationIdentification8))]
        [XmlElement("PrvtId", typeof(PersonIdentification5))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class OrganisationIdentification8
    {

        private string anyBICField;

        private GenericOrganisationIdentification1[] othrField;

       
        public string AnyBIC
        {
            get
            {
                return this.anyBICField;
            }
            set
            {
                this.anyBICField = value;
            }
        }

       
        [XmlElement("Othr")]
        public GenericOrganisationIdentification1[] Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class GenericOrganisationIdentification1
    {

        private string idField;

        private OrganisationIdentificationSchemeName1Choice schmeNmField;

        private string issrField;

       
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

       
        public OrganisationIdentificationSchemeName1Choice SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }

       
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class OrganisationIdentificationSchemeName1Choice
    {

        private string itemField;

        private ItemChoiceType itemElementNameField;

       
        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

       
        [XmlIgnore()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

       
        Cd,

       
        Prtry,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class PersonIdentification5
    {

        private DateAndPlaceOfBirth dtAndPlcOfBirthField;

        private GenericPersonIdentification1[] othrField;

       
        public DateAndPlaceOfBirth DtAndPlcOfBirth
        {
            get
            {
                return this.dtAndPlcOfBirthField;
            }
            set
            {
                this.dtAndPlcOfBirthField = value;
            }
        }

       
        [XmlElement("Othr")]
        public GenericPersonIdentification1[] Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class DateAndPlaceOfBirth
    {

        private System.DateTime birthDtField;

        private string prvcOfBirthField;

        private string cityOfBirthField;

        private string ctryOfBirthField;

       
        [XmlElement(DataType = "date")]
        public System.DateTime BirthDt
        {
            get
            {
                return this.birthDtField;
            }
            set
            {
                this.birthDtField = value;
            }
        }

       
        public string PrvcOfBirth
        {
            get
            {
                return this.prvcOfBirthField;
            }
            set
            {
                this.prvcOfBirthField = value;
            }
        }

       
        public string CityOfBirth
        {
            get
            {
                return this.cityOfBirthField;
            }
            set
            {
                this.cityOfBirthField = value;
            }
        }

       
        public string CtryOfBirth
        {
            get
            {
                return this.ctryOfBirthField;
            }
            set
            {
                this.ctryOfBirthField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class GenericPersonIdentification1
    {

        private string idField;

        private PersonIdentificationSchemeName1Choice schmeNmField;

        private string issrField;

       
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

       
        public PersonIdentificationSchemeName1Choice SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }

       
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class PersonIdentificationSchemeName1Choice
    {

        private string itemField;

        private ItemChoiceType1 itemElementNameField;

       
        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

       
        [XmlIgnore()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

       
        Cd,

       
        Prtry,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class ContactDetails2
    {

        private NamePrefix1Code nmPrfxField;

        private bool nmPrfxFieldSpecified;

        private string nmField;

        private string phneNbField;

        private string mobNbField;

        private string faxNbField;

        private string emailAdrField;

        private string othrField;

       
        public NamePrefix1Code NmPrfx
        {
            get
            {
                return this.nmPrfxField;
            }
            set
            {
                this.nmPrfxField = value;
            }
        }

       
        [XmlIgnore()]
        public bool NmPrfxSpecified
        {
            get
            {
                return this.nmPrfxFieldSpecified;
            }
            set
            {
                this.nmPrfxFieldSpecified = value;
            }
        }

       
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

       
        public string PhneNb
        {
            get
            {
                return this.phneNbField;
            }
            set
            {
                this.phneNbField = value;
            }
        }

       
        public string MobNb
        {
            get
            {
                return this.mobNbField;
            }
            set
            {
                this.mobNbField = value;
            }
        }

       
        public string FaxNb
        {
            get
            {
                return this.faxNbField;
            }
            set
            {
                this.faxNbField = value;
            }
        }

       
        public string EmailAdr
        {
            get
            {
                return this.emailAdrField;
            }
            set
            {
                this.emailAdrField = value;
            }
        }

       
        public string Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public enum NamePrefix1Code
    {

       
        DOCT,

       
        MIST,

       
        MISS,

       
        MADM,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class RemittanceInformation7
    {

        private string[] ustrdField;

        private StructuredRemittanceInformation9[] strdField;

       
        [XmlElement("Ustrd")]
        public string[] Ustrd
        {
            get
            {
                return this.ustrdField;
            }
            set
            {
                this.ustrdField = value;
            }
        }

       
        [XmlElement("Strd")]
        public StructuredRemittanceInformation9[] Strd
        {
            get
            {
                return this.strdField;
            }
            set
            {
                this.strdField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class NameAndAddress10
    {

        private string nmField;

        private PostalAddress6 adrField;

       
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

       
        public PostalAddress6 Adr
        {
            get
            {
                return this.adrField;
            }
            set
            {
                this.adrField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class RemittanceLocation2
    {

        private string rmtIdField;

        private RemittanceLocationMethod2Code rmtLctnMtdField;

        private bool rmtLctnMtdFieldSpecified;

        private string rmtLctnElctrncAdrField;

        private NameAndAddress10 rmtLctnPstlAdrField;

       
        public string RmtId
        {
            get
            {
                return this.rmtIdField;
            }
            set
            {
                this.rmtIdField = value;
            }
        }

       
        public RemittanceLocationMethod2Code RmtLctnMtd
        {
            get
            {
                return this.rmtLctnMtdField;
            }
            set
            {
                this.rmtLctnMtdField = value;
            }
        }

       
        [XmlIgnore()]
        public bool RmtLctnMtdSpecified
        {
            get
            {
                return this.rmtLctnMtdFieldSpecified;
            }
            set
            {
                this.rmtLctnMtdFieldSpecified = value;
            }
        }

       
        public string RmtLctnElctrncAdr
        {
            get
            {
                return this.rmtLctnElctrncAdrField;
            }
            set
            {
                this.rmtLctnElctrncAdrField = value;
            }
        }

       
        public NameAndAddress10 RmtLctnPstlAdr
        {
            get
            {
                return this.rmtLctnPstlAdrField;
            }
            set
            {
                this.rmtLctnPstlAdrField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public enum RemittanceLocationMethod2Code
    {

       
        FAXI,

       
        EDIC,

       
        URID,

       
        EMAL,

       
        POST,

       
        SMSM,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class TaxRecordDetails1
    {

        private TaxPeriod1 prdField;

        private ActiveOrHistoricCurrencyAndAmount amtField;

       
        public TaxPeriod1 Prd
        {
            get
            {
                return this.prdField;
            }
            set
            {
                this.prdField = value;
            }
        }

       
        public ActiveOrHistoricCurrencyAndAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class TaxPeriod1
    {

        private System.DateTime yrField;

        private bool yrFieldSpecified;

        private TaxRecordPeriod1Code tpField;

        private bool tpFieldSpecified;

        private DatePeriodDetails frToDtField;

       
        [XmlElement(DataType = "date")]
        public System.DateTime Yr
        {
            get
            {
                return this.yrField;
            }
            set
            {
                this.yrField = value;
            }
        }

       
        [XmlIgnore()]
        public bool YrSpecified
        {
            get
            {
                return this.yrFieldSpecified;
            }
            set
            {
                this.yrFieldSpecified = value;
            }
        }

       
        public TaxRecordPeriod1Code Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

       
        [XmlIgnore()]
        public bool TpSpecified
        {
            get
            {
                return this.tpFieldSpecified;
            }
            set
            {
                this.tpFieldSpecified = value;
            }
        }

       
        public DatePeriodDetails FrToDt
        {
            get
            {
                return this.frToDtField;
            }
            set
            {
                this.frToDtField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public enum TaxRecordPeriod1Code
    {

       
        MM01,

       
        MM02,

       
        MM03,

       
        MM04,

       
        MM05,

       
        MM06,

       
        MM07,

       
        MM08,

       
        MM09,

       
        MM10,

       
        MM11,

       
        MM12,

       
        QTR1,

       
        QTR2,

       
        QTR3,

       
        QTR4,

       
        HLF1,

       
        HLF2,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class DatePeriodDetails
    {

        private System.DateTime frDtField;

        private System.DateTime toDtField;

       
        [XmlElement(DataType = "date")]
        public System.DateTime FrDt
        {
            get
            {
                return this.frDtField;
            }
            set
            {
                this.frDtField = value;
            }
        }

       
        [XmlElement(DataType = "date")]
        public System.DateTime ToDt
        {
            get
            {
                return this.toDtField;
            }
            set
            {
                this.toDtField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class TaxAmount1
    {

        private decimal rateField;

        private bool rateFieldSpecified;

        private ActiveOrHistoricCurrencyAndAmount taxblBaseAmtField;

        private ActiveOrHistoricCurrencyAndAmount ttlAmtField;

        private TaxRecordDetails1[] dtlsField;

       
        public decimal Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

       
        [XmlIgnore()]
        public bool RateSpecified
        {
            get
            {
                return this.rateFieldSpecified;
            }
            set
            {
                this.rateFieldSpecified = value;
            }
        }

       
        public ActiveOrHistoricCurrencyAndAmount TaxblBaseAmt
        {
            get
            {
                return this.taxblBaseAmtField;
            }
            set
            {
                this.taxblBaseAmtField = value;
            }
        }

       
        public ActiveOrHistoricCurrencyAndAmount TtlAmt
        {
            get
            {
                return this.ttlAmtField;
            }
            set
            {
                this.ttlAmtField = value;
            }
        }

       
        [XmlElement("Dtls")]
        public TaxRecordDetails1[] Dtls
        {
            get
            {
                return this.dtlsField;
            }
            set
            {
                this.dtlsField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class TaxRecord1
    {

        private string tpField;

        private string ctgyField;

        private string ctgyDtlsField;

        private string dbtrStsField;

        private string certIdField;

        private string frmsCdField;

        private TaxPeriod1 prdField;

        private TaxAmount1 taxAmtField;

        private string addtlInfField;

       
        public string Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

       
        public string Ctgy
        {
            get
            {
                return this.ctgyField;
            }
            set
            {
                this.ctgyField = value;
            }
        }

       
        public string CtgyDtls
        {
            get
            {
                return this.ctgyDtlsField;
            }
            set
            {
                this.ctgyDtlsField = value;
            }
        }

       
        public string DbtrSts
        {
            get
            {
                return this.dbtrStsField;
            }
            set
            {
                this.dbtrStsField = value;
            }
        }

       
        public string CertId
        {
            get
            {
                return this.certIdField;
            }
            set
            {
                this.certIdField = value;
            }
        }

       
        public string FrmsCd
        {
            get
            {
                return this.frmsCdField;
            }
            set
            {
                this.frmsCdField = value;
            }
        }

       
        public TaxPeriod1 Prd
        {
            get
            {
                return this.prdField;
            }
            set
            {
                this.prdField = value;
            }
        }

       
        public TaxAmount1 TaxAmt
        {
            get
            {
                return this.taxAmtField;
            }
            set
            {
                this.taxAmtField = value;
            }
        }

       
        public string AddtlInf
        {
            get
            {
                return this.addtlInfField;
            }
            set
            {
                this.addtlInfField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class TaxAuthorisation1
    {

        private string titlField;

        private string nmField;

       
        public string Titl
        {
            get
            {
                return this.titlField;
            }
            set
            {
                this.titlField = value;
            }
        }

       
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class TaxParty2
    {

        private string taxIdField;

        private string regnIdField;

        private string taxTpField;

        private TaxAuthorisation1 authstnField;

       
        public string TaxId
        {
            get
            {
                return this.taxIdField;
            }
            set
            {
                this.taxIdField = value;
            }
        }

       
        public string RegnId
        {
            get
            {
                return this.regnIdField;
            }
            set
            {
                this.regnIdField = value;
            }
        }

       
        public string TaxTp
        {
            get
            {
                return this.taxTpField;
            }
            set
            {
                this.taxTpField = value;
            }
        }

       
        public TaxAuthorisation1 Authstn
        {
            get
            {
                return this.authstnField;
            }
            set
            {
                this.authstnField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class TaxParty1
    {

        private string taxIdField;

        private string regnIdField;

        private string taxTpField;

       
        public string TaxId
        {
            get
            {
                return this.taxIdField;
            }
            set
            {
                this.taxIdField = value;
            }
        }

       
        public string RegnId
        {
            get
            {
                return this.regnIdField;
            }
            set
            {
                this.regnIdField = value;
            }
        }

       
        public string TaxTp
        {
            get
            {
                return this.taxTpField;
            }
            set
            {
                this.taxTpField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class TaxInformation3
    {

        private TaxParty1 cdtrField;

        private TaxParty2 dbtrField;

        private string admstnZnField;

        private string refNbField;

        private string mtdField;

        private ActiveOrHistoricCurrencyAndAmount ttlTaxblBaseAmtField;

        private ActiveOrHistoricCurrencyAndAmount ttlTaxAmtField;

        private System.DateTime dtField;

        private bool dtFieldSpecified;

        private decimal seqNbField;

        private bool seqNbFieldSpecified;

        private TaxRecord1[] rcrdField;

       
        public TaxParty1 Cdtr
        {
            get
            {
                return this.cdtrField;
            }
            set
            {
                this.cdtrField = value;
            }
        }

       
        public TaxParty2 Dbtr
        {
            get
            {
                return this.dbtrField;
            }
            set
            {
                this.dbtrField = value;
            }
        }

       
        public string AdmstnZn
        {
            get
            {
                return this.admstnZnField;
            }
            set
            {
                this.admstnZnField = value;
            }
        }

       
        public string RefNb
        {
            get
            {
                return this.refNbField;
            }
            set
            {
                this.refNbField = value;
            }
        }

       
        public string Mtd
        {
            get
            {
                return this.mtdField;
            }
            set
            {
                this.mtdField = value;
            }
        }

       
        public ActiveOrHistoricCurrencyAndAmount TtlTaxblBaseAmt
        {
            get
            {
                return this.ttlTaxblBaseAmtField;
            }
            set
            {
                this.ttlTaxblBaseAmtField = value;
            }
        }

       
        public ActiveOrHistoricCurrencyAndAmount TtlTaxAmt
        {
            get
            {
                return this.ttlTaxAmtField;
            }
            set
            {
                this.ttlTaxAmtField = value;
            }
        }

       
        [XmlElement(DataType = "date")]
        public System.DateTime Dt
        {
            get
            {
                return this.dtField;
            }
            set
            {
                this.dtField = value;
            }
        }

       
        [XmlIgnore()]
        public bool DtSpecified
        {
            get
            {
                return this.dtFieldSpecified;
            }
            set
            {
                this.dtFieldSpecified = value;
            }
        }

       
        public decimal SeqNb
        {
            get
            {
                return this.seqNbField;
            }
            set
            {
                this.seqNbField = value;
            }
        }

       
        [XmlIgnore()]
        public bool SeqNbSpecified
        {
            get
            {
                return this.seqNbFieldSpecified;
            }
            set
            {
                this.seqNbFieldSpecified = value;
            }
        }

       
        [XmlElement("Rcrd")]
        public TaxRecord1[] Rcrd
        {
            get
            {
                return this.rcrdField;
            }
            set
            {
                this.rcrdField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class StructuredRegulatoryReporting3
    {

        private string tpField;

        private System.DateTime dtField;

        private bool dtFieldSpecified;

        private string ctryField;

        private string cdField;

        private ActiveOrHistoricCurrencyAndAmount amtField;

        private string[] infField;

       
        public string Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

       
        [XmlElement(DataType = "date")]
        public System.DateTime Dt
        {
            get
            {
                return this.dtField;
            }
            set
            {
                this.dtField = value;
            }
        }

       
        [XmlIgnore()]
        public bool DtSpecified
        {
            get
            {
                return this.dtFieldSpecified;
            }
            set
            {
                this.dtFieldSpecified = value;
            }
        }

       
        public string Ctry
        {
            get
            {
                return this.ctryField;
            }
            set
            {
                this.ctryField = value;
            }
        }

       
        public string Cd
        {
            get
            {
                return this.cdField;
            }
            set
            {
                this.cdField = value;
            }
        }

       
        public ActiveOrHistoricCurrencyAndAmount Amt
        {
            get
            {
                return this.amtField;
            }
            set
            {
                this.amtField = value;
            }
        }

       
        [XmlElement("Inf")]
        public string[] Inf
        {
            get
            {
                return this.infField;
            }
            set
            {
                this.infField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class RegulatoryAuthority2
    {

        private string nmField;

        private string ctryField;

       
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

       
        public string Ctry
        {
            get
            {
                return this.ctryField;
            }
            set
            {
                this.ctryField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class RegulatoryReporting3
    {

        private RegulatoryReportingType1Code dbtCdtRptgIndField;

        private bool dbtCdtRptgIndFieldSpecified;

        private RegulatoryAuthority2 authrtyField;

        private StructuredRegulatoryReporting3[] dtlsField;

       
        public RegulatoryReportingType1Code DbtCdtRptgInd
        {
            get
            {
                return this.dbtCdtRptgIndField;
            }
            set
            {
                this.dbtCdtRptgIndField = value;
            }
        }

       
        [XmlIgnore()]
        public bool DbtCdtRptgIndSpecified
        {
            get
            {
                return this.dbtCdtRptgIndFieldSpecified;
            }
            set
            {
                this.dbtCdtRptgIndFieldSpecified = value;
            }
        }

       
        public RegulatoryAuthority2 Authrty
        {
            get
            {
                return this.authrtyField;
            }
            set
            {
                this.authrtyField = value;
            }
        }

       
        [XmlElement("Dtls")]
        public StructuredRegulatoryReporting3[] Dtls
        {
            get
            {
                return this.dtlsField;
            }
            set
            {
                this.dtlsField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public enum RegulatoryReportingType1Code
    {

       
        CRED,

       
        DEBT,

       
        BOTH,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class Purpose2Choice
    {

        private string itemField;

        private ItemChoiceType9 itemElementNameField;

       
        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

       
        [XmlIgnore()]
        public ItemChoiceType9 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IncludeInSchema = false)]
    public enum ItemChoiceType9
    {

       
        Cd,

       
        Prtry,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class AmendmentInformationDetails8
    {

        private string orgnlMndtIdField;

        private PartyIdentification43 orgnlCdtrSchmeIdField;

        private BranchAndFinancialInstitutionIdentification5 orgnlCdtrAgtField;

        private CashAccount24 orgnlCdtrAgtAcctField;

        private PartyIdentification43 orgnlDbtrField;

        private CashAccount24 orgnlDbtrAcctField;

        private BranchAndFinancialInstitutionIdentification5 orgnlDbtrAgtField;

        private CashAccount24 orgnlDbtrAgtAcctField;

        private System.DateTime orgnlFnlColltnDtField;

        private bool orgnlFnlColltnDtFieldSpecified;

        private Frequency6Code orgnlFrqcyField;

        private bool orgnlFrqcyFieldSpecified;

       
        public string OrgnlMndtId
        {
            get
            {
                return this.orgnlMndtIdField;
            }
            set
            {
                this.orgnlMndtIdField = value;
            }
        }

       
        public PartyIdentification43 OrgnlCdtrSchmeId
        {
            get
            {
                return this.orgnlCdtrSchmeIdField;
            }
            set
            {
                this.orgnlCdtrSchmeIdField = value;
            }
        }

       
        public BranchAndFinancialInstitutionIdentification5 OrgnlCdtrAgt
        {
            get
            {
                return this.orgnlCdtrAgtField;
            }
            set
            {
                this.orgnlCdtrAgtField = value;
            }
        }

       
        public CashAccount24 OrgnlCdtrAgtAcct
        {
            get
            {
                return this.orgnlCdtrAgtAcctField;
            }
            set
            {
                this.orgnlCdtrAgtAcctField = value;
            }
        }

       
        public PartyIdentification43 OrgnlDbtr
        {
            get
            {
                return this.orgnlDbtrField;
            }
            set
            {
                this.orgnlDbtrField = value;
            }
        }

       
        public CashAccount24 OrgnlDbtrAcct
        {
            get
            {
                return this.orgnlDbtrAcctField;
            }
            set
            {
                this.orgnlDbtrAcctField = value;
            }
        }

       
        public BranchAndFinancialInstitutionIdentification5 OrgnlDbtrAgt
        {
            get
            {
                return this.orgnlDbtrAgtField;
            }
            set
            {
                this.orgnlDbtrAgtField = value;
            }
        }

       
        public CashAccount24 OrgnlDbtrAgtAcct
        {
            get
            {
                return this.orgnlDbtrAgtAcctField;
            }
            set
            {
                this.orgnlDbtrAgtAcctField = value;
            }
        }

       
        [XmlElement(DataType = "date")]
        public System.DateTime OrgnlFnlColltnDt
        {
            get
            {
                return this.orgnlFnlColltnDtField;
            }
            set
            {
                this.orgnlFnlColltnDtField = value;
            }
        }

       
        [XmlIgnore()]
        public bool OrgnlFnlColltnDtSpecified
        {
            get
            {
                return this.orgnlFnlColltnDtFieldSpecified;
            }
            set
            {
                this.orgnlFnlColltnDtFieldSpecified = value;
            }
        }

       
        public Frequency6Code OrgnlFrqcy
        {
            get
            {
                return this.orgnlFrqcyField;
            }
            set
            {
                this.orgnlFrqcyField = value;
            }
        }

       
        [XmlIgnore()]
        public bool OrgnlFrqcySpecified
        {
            get
            {
                return this.orgnlFrqcyFieldSpecified;
            }
            set
            {
                this.orgnlFrqcyFieldSpecified = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class BranchAndFinancialInstitutionIdentification5
    {

        private FinancialInstitutionIdentification8 finInstnIdField;

        private BranchData2 brnchIdField;

       
        public FinancialInstitutionIdentification8 FinInstnId
        {
            get
            {
                return this.finInstnIdField;
            }
            set
            {
                this.finInstnIdField = value;
            }
        }

       
        public BranchData2 BrnchId
        {
            get
            {
                return this.brnchIdField;
            }
            set
            {
                this.brnchIdField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class FinancialInstitutionIdentification8
    {

        private string bICFIField;

        private ClearingSystemMemberIdentification2 clrSysMmbIdField;

        private string nmField;

        private PostalAddress6 pstlAdrField;

        private GenericFinancialIdentification1 othrField;

       
        public string BICFI
        {
            get
            {
                return this.bICFIField;
            }
            set
            {
                this.bICFIField = value;
            }
        }

       
        public ClearingSystemMemberIdentification2 ClrSysMmbId
        {
            get
            {
                return this.clrSysMmbIdField;
            }
            set
            {
                this.clrSysMmbIdField = value;
            }
        }

       
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

       
        public PostalAddress6 PstlAdr
        {
            get
            {
                return this.pstlAdrField;
            }
            set
            {
                this.pstlAdrField = value;
            }
        }

       
        public GenericFinancialIdentification1 Othr
        {
            get
            {
                return this.othrField;
            }
            set
            {
                this.othrField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class ClearingSystemMemberIdentification2
    {

        private ClearingSystemIdentification2Choice clrSysIdField;

        private string mmbIdField;

       
        public ClearingSystemIdentification2Choice ClrSysId
        {
            get
            {
                return this.clrSysIdField;
            }
            set
            {
                this.clrSysIdField = value;
            }
        }

       
        public string MmbId
        {
            get
            {
                return this.mmbIdField;
            }
            set
            {
                this.mmbIdField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class ClearingSystemIdentification2Choice
    {

        private string itemField;

        private ItemChoiceType2 itemElementNameField;

       
        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

       
        [XmlIgnore()]
        public ItemChoiceType2 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IncludeInSchema = false)]
    public enum ItemChoiceType2
    {

       
        Cd,

       
        Prtry,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class GenericFinancialIdentification1
    {

        private string idField;

        private FinancialIdentificationSchemeName1Choice schmeNmField;

        private string issrField;

       
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

       
        public FinancialIdentificationSchemeName1Choice SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }

       
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class FinancialIdentificationSchemeName1Choice
    {

        private string itemField;

        private ItemChoiceType3 itemElementNameField;

       
        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

       
        [XmlIgnore()]
        public ItemChoiceType3 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IncludeInSchema = false)]
    public enum ItemChoiceType3
    {

       
        Cd,

       
        Prtry,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class BranchData2
    {

        private string idField;

        private string nmField;

        private PostalAddress6 pstlAdrField;

       
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

       
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }

       
        public PostalAddress6 PstlAdr
        {
            get
            {
                return this.pstlAdrField;
            }
            set
            {
                this.pstlAdrField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class CashAccount24
    {

        private AccountIdentification4Choice idField;

        private CashAccountType2Choice tpField;

        private string ccyField;

        private string nmField;

       
        public AccountIdentification4Choice Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

       
        public CashAccountType2Choice Tp
        {
            get
            {
                return this.tpField;
            }
            set
            {
                this.tpField = value;
            }
        }

       
        public string Ccy
        {
            get
            {
                return this.ccyField;
            }
            set
            {
                this.ccyField = value;
            }
        }

       
        public string Nm
        {
            get
            {
                return this.nmField;
            }
            set
            {
                this.nmField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class AccountIdentification4Choice
    {

        private object itemField;

       
        [XmlElement("IBAN", typeof(string))]
        [XmlElement("Othr", typeof(GenericAccountIdentification1))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class GenericAccountIdentification1
    {

        private string idField;

        private AccountSchemeName1Choice schmeNmField;

        private string issrField;

       
        public string Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

       
        public AccountSchemeName1Choice SchmeNm
        {
            get
            {
                return this.schmeNmField;
            }
            set
            {
                this.schmeNmField = value;
            }
        }

       
        public string Issr
        {
            get
            {
                return this.issrField;
            }
            set
            {
                this.issrField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class AccountSchemeName1Choice
    {

        private string itemField;

        private ItemChoiceType7 itemElementNameField;

       
        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

       
        [XmlIgnore()]
        public ItemChoiceType7 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IncludeInSchema = false)]
    public enum ItemChoiceType7
    {

       
        Cd,

       
        Prtry,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class CashAccountType2Choice
    {

        private string itemField;

        private ItemChoiceType8 itemElementNameField;

       
        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

       
        [XmlIgnore()]
        public ItemChoiceType8 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IncludeInSchema = false)]
    public enum ItemChoiceType8
    {

       
        Cd,

       
        Prtry,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public enum Frequency6Code
    {

       
        YEAR,

       
        MNTH,

       
        QURT,

       
        MIAN,

       
        WEEK,

       
        DAIL,

       
        ADHO,

       
        INDA,

       
        FRTN,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class MandateRelatedInformation8
    {

        private string mndtIdField;

        private System.DateTime dtOfSgntrField;

        private bool dtOfSgntrFieldSpecified;

        private bool amdmntIndField;

        private bool amdmntIndFieldSpecified;

        private AmendmentInformationDetails8 amdmntInfDtlsField;

        private string elctrncSgntrField;

        private System.DateTime frstColltnDtField;

        private bool frstColltnDtFieldSpecified;

        private System.DateTime fnlColltnDtField;

        private bool fnlColltnDtFieldSpecified;

        private Frequency6Code frqcyField;

        private bool frqcyFieldSpecified;

       
        public string MndtId
        {
            get
            {
                return this.mndtIdField;
            }
            set
            {
                this.mndtIdField = value;
            }
        }

       
        [XmlElement(DataType = "date")]
        public System.DateTime DtOfSgntr
        {
            get
            {
                return this.dtOfSgntrField;
            }
            set
            {
                this.dtOfSgntrField = value;
            }
        }

       
        [XmlIgnore()]
        public bool DtOfSgntrSpecified
        {
            get
            {
                return this.dtOfSgntrFieldSpecified;
            }
            set
            {
                this.dtOfSgntrFieldSpecified = value;
            }
        }

       
        public bool AmdmntInd
        {
            get
            {
                return this.amdmntIndField;
            }
            set
            {
                this.amdmntIndField = value;
            }
        }

       
        [XmlIgnore()]
        public bool AmdmntIndSpecified
        {
            get
            {
                return this.amdmntIndFieldSpecified;
            }
            set
            {
                this.amdmntIndFieldSpecified = value;
            }
        }

       
        public AmendmentInformationDetails8 AmdmntInfDtls
        {
            get
            {
                return this.amdmntInfDtlsField;
            }
            set
            {
                this.amdmntInfDtlsField = value;
            }
        }

       
        public string ElctrncSgntr
        {
            get
            {
                return this.elctrncSgntrField;
            }
            set
            {
                this.elctrncSgntrField = value;
            }
        }

       
        [XmlElement(DataType = "date")]
        public System.DateTime FrstColltnDt
        {
            get
            {
                return this.frstColltnDtField;
            }
            set
            {
                this.frstColltnDtField = value;
            }
        }

       
        [XmlIgnore()]
        public bool FrstColltnDtSpecified
        {
            get
            {
                return this.frstColltnDtFieldSpecified;
            }
            set
            {
                this.frstColltnDtFieldSpecified = value;
            }
        }

       
        [XmlElement(DataType = "date")]
        public System.DateTime FnlColltnDt
        {
            get
            {
                return this.fnlColltnDtField;
            }
            set
            {
                this.fnlColltnDtField = value;
            }
        }

       
        [XmlIgnore()]
        public bool FnlColltnDtSpecified
        {
            get
            {
                return this.fnlColltnDtFieldSpecified;
            }
            set
            {
                this.fnlColltnDtFieldSpecified = value;
            }
        }

       
        public Frequency6Code Frqcy
        {
            get
            {
                return this.frqcyField;
            }
            set
            {
                this.frqcyField = value;
            }
        }

       
        [XmlIgnore()]
        public bool FrqcySpecified
        {
            get
            {
                return this.frqcyFieldSpecified;
            }
            set
            {
                this.frqcyFieldSpecified = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class DirectDebitTransaction7
    {

        private MandateRelatedInformation8 mndtRltdInfField;

        private PartyIdentification43 cdtrSchmeIdField;

        private string preNtfctnIdField;

        private System.DateTime preNtfctnDtField;

        private bool preNtfctnDtFieldSpecified;

       
        public MandateRelatedInformation8 MndtRltdInf
        {
            get
            {
                return this.mndtRltdInfField;
            }
            set
            {
                this.mndtRltdInfField = value;
            }
        }

       
        public PartyIdentification43 CdtrSchmeId
        {
            get
            {
                return this.cdtrSchmeIdField;
            }
            set
            {
                this.cdtrSchmeIdField = value;
            }
        }

       
        public string PreNtfctnId
        {
            get
            {
                return this.preNtfctnIdField;
            }
            set
            {
                this.preNtfctnIdField = value;
            }
        }

       
        [XmlElement(DataType = "date")]
        public System.DateTime PreNtfctnDt
        {
            get
            {
                return this.preNtfctnDtField;
            }
            set
            {
                this.preNtfctnDtField = value;
            }
        }

       
        [XmlIgnore()]
        public bool PreNtfctnDtSpecified
        {
            get
            {
                return this.preNtfctnDtFieldSpecified;
            }
            set
            {
                this.preNtfctnDtFieldSpecified = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class PaymentIdentification1
    {

        private string instrIdField;

        private string endToEndIdField;

       
        public string InstrId
        {
            get
            {
                return this.instrIdField;
            }
            set
            {
                this.instrIdField = value;
            }
        }

       
        public string EndToEndId
        {
            get
            {
                return this.endToEndIdField;
            }
            set
            {
                this.endToEndIdField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class DirectDebitTransactionInformation13
    {

        private PaymentIdentification1 pmtIdField;

        private PaymentTypeInformation24 pmtTpInfField;

        private ActiveOrHistoricCurrencyAndAmount instdAmtField;

        private ChargeBearerType1Code chrgBrField;

        private bool chrgBrFieldSpecified;

        private DirectDebitTransaction7 drctDbtTxField;

        private PartyIdentification43 ultmtCdtrField;

        private BranchAndFinancialInstitutionIdentification5 dbtrAgtField;

        private CashAccount24 dbtrAgtAcctField;

        private PartyIdentification43 dbtrField;

        private CashAccount24 dbtrAcctField;

        private PartyIdentification43 ultmtDbtrField;

        private string instrForCdtrAgtField;

        private Purpose2Choice purpField;

        private RegulatoryReporting3[] rgltryRptgField;

        private TaxInformation3 taxField;

        private RemittanceLocation2[] rltdRmtInfField;

        private RemittanceInformation7 rmtInfField;

        private SupplementaryData1[] splmtryDataField;

       
        public PaymentIdentification1 PmtId
        {
            get
            {
                return this.pmtIdField;
            }
            set
            {
                this.pmtIdField = value;
            }
        }

       
        public PaymentTypeInformation24 PmtTpInf
        {
            get
            {
                return this.pmtTpInfField;
            }
            set
            {
                this.pmtTpInfField = value;
            }
        }

       
        public ActiveOrHistoricCurrencyAndAmount InstdAmt
        {
            get
            {
                return this.instdAmtField;
            }
            set
            {
                this.instdAmtField = value;
            }
        }

       
        public ChargeBearerType1Code ChrgBr
        {
            get
            {
                return this.chrgBrField;
            }
            set
            {
                this.chrgBrField = value;
            }
        }

       
        [XmlIgnore()]
        public bool ChrgBrSpecified
        {
            get
            {
                return this.chrgBrFieldSpecified;
            }
            set
            {
                this.chrgBrFieldSpecified = value;
            }
        }

       
        public DirectDebitTransaction7 DrctDbtTx
        {
            get
            {
                return this.drctDbtTxField;
            }
            set
            {
                this.drctDbtTxField = value;
            }
        }

       
        public PartyIdentification43 UltmtCdtr
        {
            get
            {
                return this.ultmtCdtrField;
            }
            set
            {
                this.ultmtCdtrField = value;
            }
        }

       
        public BranchAndFinancialInstitutionIdentification5 DbtrAgt
        {
            get
            {
                return this.dbtrAgtField;
            }
            set
            {
                this.dbtrAgtField = value;
            }
        }

       
        public CashAccount24 DbtrAgtAcct
        {
            get
            {
                return this.dbtrAgtAcctField;
            }
            set
            {
                this.dbtrAgtAcctField = value;
            }
        }

       
        public PartyIdentification43 Dbtr
        {
            get
            {
                return this.dbtrField;
            }
            set
            {
                this.dbtrField = value;
            }
        }

       
        public CashAccount24 DbtrAcct
        {
            get
            {
                return this.dbtrAcctField;
            }
            set
            {
                this.dbtrAcctField = value;
            }
        }

       
        public PartyIdentification43 UltmtDbtr
        {
            get
            {
                return this.ultmtDbtrField;
            }
            set
            {
                this.ultmtDbtrField = value;
            }
        }

       
        public string InstrForCdtrAgt
        {
            get
            {
                return this.instrForCdtrAgtField;
            }
            set
            {
                this.instrForCdtrAgtField = value;
            }
        }

       
        public Purpose2Choice Purp
        {
            get
            {
                return this.purpField;
            }
            set
            {
                this.purpField = value;
            }
        }

       
        [XmlElement("RgltryRptg")]
        public RegulatoryReporting3[] RgltryRptg
        {
            get
            {
                return this.rgltryRptgField;
            }
            set
            {
                this.rgltryRptgField = value;
            }
        }

       
        public TaxInformation3 Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

       
        [XmlElement("RltdRmtInf")]
        public RemittanceLocation2[] RltdRmtInf
        {
            get
            {
                return this.rltdRmtInfField;
            }
            set
            {
                this.rltdRmtInfField = value;
            }
        }

       
        public RemittanceInformation7 RmtInf
        {
            get
            {
                return this.rmtInfField;
            }
            set
            {
                this.rmtInfField = value;
            }
        }

       
        [XmlElement("SplmtryData")]
        public SupplementaryData1[] SplmtryData
        {
            get
            {
                return this.splmtryDataField;
            }
            set
            {
                this.splmtryDataField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class PaymentTypeInformation24
    {

        private Priority2Code instrPrtyField;

        private bool instrPrtyFieldSpecified;

        private ServiceLevel8Choice svcLvlField;

        private LocalInstrument2Choice lclInstrmField;

        private SequenceType3Code seqTpField;

        private bool seqTpFieldSpecified;

        private CategoryPurpose1Choice ctgyPurpField;

       
        public Priority2Code InstrPrty
        {
            get
            {
                return this.instrPrtyField;
            }
            set
            {
                this.instrPrtyField = value;
            }
        }

       
        [XmlIgnore()]
        public bool InstrPrtySpecified
        {
            get
            {
                return this.instrPrtyFieldSpecified;
            }
            set
            {
                this.instrPrtyFieldSpecified = value;
            }
        }

       
        public ServiceLevel8Choice SvcLvl
        {
            get
            {
                return this.svcLvlField;
            }
            set
            {
                this.svcLvlField = value;
            }
        }

       
        public LocalInstrument2Choice LclInstrm
        {
            get
            {
                return this.lclInstrmField;
            }
            set
            {
                this.lclInstrmField = value;
            }
        }

       
        public SequenceType3Code SeqTp
        {
            get
            {
                return this.seqTpField;
            }
            set
            {
                this.seqTpField = value;
            }
        }

       
        [XmlIgnore()]
        public bool SeqTpSpecified
        {
            get
            {
                return this.seqTpFieldSpecified;
            }
            set
            {
                this.seqTpFieldSpecified = value;
            }
        }

       
        public CategoryPurpose1Choice CtgyPurp
        {
            get
            {
                return this.ctgyPurpField;
            }
            set
            {
                this.ctgyPurpField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public enum Priority2Code
    {

       
        HIGH,

       
        NORM,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class ServiceLevel8Choice
    {

        private string itemField;

        private ItemChoiceType4 itemElementNameField;

       
        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

       
        [XmlIgnore()]
        public ItemChoiceType4 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IncludeInSchema = false)]
    public enum ItemChoiceType4
    {

       
        Cd,

       
        Prtry,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class LocalInstrument2Choice
    {

        private string itemField;

        private ItemChoiceType5 itemElementNameField;

       
        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

       
        [XmlIgnore()]
        public ItemChoiceType5 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IncludeInSchema = false)]
    public enum ItemChoiceType5
    {

       
        Cd,

       
        Prtry,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public enum SequenceType3Code
    {

       
        FRST,

       
        RCUR,

       
        FNAL,

       
        OOFF,

       
        RPRE,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class CategoryPurpose1Choice
    {

        private string itemField;

        private ItemChoiceType6 itemElementNameField;

       
        [XmlElement("Cd", typeof(string))]
        [XmlElement("Prtry", typeof(string))]
        [XmlChoiceIdentifier("ItemElementName")]
        public string Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

       
        [XmlIgnore()]
        public ItemChoiceType6 ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04", IncludeInSchema = false)]
    public enum ItemChoiceType6
    {

       
        Cd,

       
        Prtry,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public enum ChargeBearerType1Code
    {

       
        DEBT,

       
        CRED,

       
        SHAR,

       
        SLEV,
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]



    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public partial class PaymentInstruction10
    {

        private string pmtInfIdField;

        private PaymentMethod2Code pmtMtdField;

        private bool btchBookgField;

        private bool btchBookgFieldSpecified;

        private string nbOfTxsField;

        private decimal ctrlSumField;

        private bool ctrlSumFieldSpecified;

        private PaymentTypeInformation24 pmtTpInfField;

        private System.DateTime reqdColltnDtField;

        private PartyIdentification43 cdtrField;

        private CashAccount24 cdtrAcctField;

        private BranchAndFinancialInstitutionIdentification5 cdtrAgtField;

        private CashAccount24 cdtrAgtAcctField;

        private PartyIdentification43 ultmtCdtrField;

        private ChargeBearerType1Code chrgBrField;

        private bool chrgBrFieldSpecified;

        private CashAccount24 chrgsAcctField;

        private BranchAndFinancialInstitutionIdentification5 chrgsAcctAgtField;

        private PartyIdentification43 cdtrSchmeIdField;

        private DirectDebitTransactionInformation13[] drctDbtTxInfField;

       
        public string PmtInfId
        {
            get
            {
                return this.pmtInfIdField;
            }
            set
            {
                this.pmtInfIdField = value;
            }
        }

       
        public PaymentMethod2Code PmtMtd
        {
            get
            {
                return this.pmtMtdField;
            }
            set
            {
                this.pmtMtdField = value;
            }
        }

       
        public bool BtchBookg
        {
            get
            {
                return this.btchBookgField;
            }
            set
            {
                this.btchBookgField = value;
            }
        }

       
        [XmlIgnore()]
        public bool BtchBookgSpecified
        {
            get
            {
                return this.btchBookgFieldSpecified;
            }
            set
            {
                this.btchBookgFieldSpecified = value;
            }
        }

       
        public string NbOfTxs
        {
            get
            {
                return this.nbOfTxsField;
            }
            set
            {
                this.nbOfTxsField = value;
            }
        }

       
        public decimal CtrlSum
        {
            get
            {
                return this.ctrlSumField;
            }
            set
            {
                this.ctrlSumField = value;
            }
        }

       
        [XmlIgnore()]
        public bool CtrlSumSpecified
        {
            get
            {
                return this.ctrlSumFieldSpecified;
            }
            set
            {
                this.ctrlSumFieldSpecified = value;
            }
        }

       
        public PaymentTypeInformation24 PmtTpInf
        {
            get
            {
                return this.pmtTpInfField;
            }
            set
            {
                this.pmtTpInfField = value;
            }
        }

       
        [XmlElement(DataType = "date")]
        public System.DateTime ReqdColltnDt
        {
            get
            {
                return this.reqdColltnDtField;
            }
            set
            {
                this.reqdColltnDtField = value;
            }
        }

       
        public PartyIdentification43 Cdtr
        {
            get
            {
                return this.cdtrField;
            }
            set
            {
                this.cdtrField = value;
            }
        }

       
        public CashAccount24 CdtrAcct
        {
            get
            {
                return this.cdtrAcctField;
            }
            set
            {
                this.cdtrAcctField = value;
            }
        }

       
        public BranchAndFinancialInstitutionIdentification5 CdtrAgt
        {
            get
            {
                return this.cdtrAgtField;
            }
            set
            {
                this.cdtrAgtField = value;
            }
        }

       
        public CashAccount24 CdtrAgtAcct
        {
            get
            {
                return this.cdtrAgtAcctField;
            }
            set
            {
                this.cdtrAgtAcctField = value;
            }
        }

       
        public PartyIdentification43 UltmtCdtr
        {
            get
            {
                return this.ultmtCdtrField;
            }
            set
            {
                this.ultmtCdtrField = value;
            }
        }

       
        public ChargeBearerType1Code ChrgBr
        {
            get
            {
                return this.chrgBrField;
            }
            set
            {
                this.chrgBrField = value;
            }
        }

       
        [XmlIgnore()]
        public bool ChrgBrSpecified
        {
            get
            {
                return this.chrgBrFieldSpecified;
            }
            set
            {
                this.chrgBrFieldSpecified = value;
            }
        }

       
        public CashAccount24 ChrgsAcct
        {
            get
            {
                return this.chrgsAcctField;
            }
            set
            {
                this.chrgsAcctField = value;
            }
        }

       
        public BranchAndFinancialInstitutionIdentification5 ChrgsAcctAgt
        {
            get
            {
                return this.chrgsAcctAgtField;
            }
            set
            {
                this.chrgsAcctAgtField = value;
            }
        }

       
        public PartyIdentification43 CdtrSchmeId
        {
            get
            {
                return this.cdtrSchmeIdField;
            }
            set
            {
                this.cdtrSchmeIdField = value;
            }
        }

       
        [XmlElement("DrctDbtTxInf")]
        public DirectDebitTransactionInformation13[] DrctDbtTxInf
        {
            get
            {
                return this.drctDbtTxInfField;
            }
            set
            {
                this.drctDbtTxInfField = value;
            }
        }
    }

   
    [System.CodeDom.Compiler.GeneratedCode("xsd", "4.6.1055.0")]

    [XmlType(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.008.001.04")]
    public enum PaymentMethod2Code
    {

       
        DD,
    }


}

