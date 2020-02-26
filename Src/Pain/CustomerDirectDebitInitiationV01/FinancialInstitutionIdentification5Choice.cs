using System.Xml.Serialization;
using System;
using Unifi.Pain;

namespace Unifi.Pain.CustomerDirectDebitInitiationV01
{
    public partial class FinancialInstitutionIdentification5Choice
    {


        [XmlElement("BIC", typeof(string))]
        [XmlElement("ClrSysMmbId", typeof(ClearingSystemMemberIdentification3Choice))]
        [XmlElement("CmbndId", typeof(FinancialInstitutionIdentification3))]
        [XmlElement("NmAndAdr", typeof(NameAndAddress7))]
        [XmlElement("PrtryId", typeof(GenericIdentification3))]
        public object Item { get; set; }

    }

}
