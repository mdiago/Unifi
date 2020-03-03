using System;
using System.Xml.Serialization;
using Unifi.Pain.CustomerDirectDebitInitiation;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{

    [Serializable()]
    public partial class CashAccount
    {

        public AccountIdentificationChoice Id { get; set; }

        public CdOrPrtryTypeChoice Tp { get; set; }

        public string Ccy { get; set; }

        public string Nm { get; set; }

        /// <summary>
        /// Válido a partir de la versión 8.
        /// </summary>
        public ProxyAccountIdentification Prxy { get; set; }

        /// <summary>
        /// Representación textual de la instancia.
        /// </summary>
        /// <returns>Representación textual de la instancia.</returns>
        public override string ToString()
        {
            return $"{Id}, {Tp}, {Nm}";
        }

    }



}

