﻿using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiationV05
{
    public partial class DatePeriodDetails
    {
        [XmlElement(DataType = "date")]
        public DateTime FrDt { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime ToDt { get; set; }

    }



}

