using System;
using System.Xml.Serialization;

namespace Unifi.Pain.CustomerDirectDebitInitiation
{
    public enum AuthorisationCode
    {


        /// <summary>
        /// <para>PreAuthorisedFile</para>
        /// <para>Indicates a file has been pre authorised or approved 
        /// within the originating customer environment and no further 
        /// approval is required.</para>
        /// </summary>
        AUTH,

        /// <summary>
        /// <para>FileLevelAuthorisationDetails</para>
        /// <para>Indicates that a file requires additional file level 
        /// approval, with the ability to view both the payment information 
        /// block and supporting customer credit transaction detail.</para>
        /// </summary>
        FDET,

        /// <summary>
        /// <para>FileLevelAuthorisationSummary</para>
        /// <para>Indicates that a file requires additional file level approval, 
        /// with the ability to view only the payment information block level 
        /// information. </para>
        /// </summary>
        FSUM,

        /// <summary>
        /// <para>InstructionLevelAuthorisation</para>
        /// <para>Indicates that a file requires all customer transactions to 
        /// be authorised or approved</para>
        /// </summary>
        ILEV

    }

}
