using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HunterW_API.Models
{
    /// <summary>
    /// The account where money is held. Users may have multiple accounts.
    /// </summary>
    public class BankAccount
    {
        /// <summary>
        /// Id Number
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id Number of Corresponding Household
        /// </summary>
        public int HouseholdId { get; set; }
        /// <summary>
        /// Id Number of Corresponding Account Type
        /// </summary>
        public int BankAccountTypeId { get; set; }
        /// <summary>
        /// Name of Account
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Amount of Money Currently in Account
        /// </summary>
        public double Balance { get; set; }
        /// <summary>
        /// Level at Which an Alert is Sent When Balance is Too Low
        /// </summary>
        public double LowAlertLevel { get; set; }
    }
}