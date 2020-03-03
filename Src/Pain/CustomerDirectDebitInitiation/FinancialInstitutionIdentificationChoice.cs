using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{
    public partial class FinancialInstitutionIdentificationChoice
    {


        //[XmlElement("BIC", typeof(string))]
        //[XmlElement("ClrSysMmbId", typeof(ClearingSystemMemberIdentificationChoice))]
        [XmlElement("CmbndId", typeof(FinancialInstitutionIdentification))]
        [XmlElement("NmAndAdr", typeof(NameAndAddress))]
        [XmlElement("PrtryId", typeof(GenericIdentification))]
        public object Item { get; set; }

    }

}
