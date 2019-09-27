using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HunterW_API.Models
{
    /// <summary>
    /// Individual Transactions Made By Users
    /// </summary>
    public class Transaction
    {
        /// <summary>
        /// Id Number
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of Transaction
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Information About Transaction
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// How Much Money Was Exchanged
        /// </summary>
        public double TransactionAmount { get; set; }
        /// <summary>
        /// Id Number of User Who Made Transaction
        /// </summary>
        public string CreatedById { get; set; }
        /// <summary>
        /// Id Number of Bank Account That Supplied Money For This Transaction
        /// </summary>
        public int BankAccountsId { get; set; }
        /// <summary>
        /// Id Number of Corresponding Transaction Type
        /// </summary>
        public int TransactionTypeId { get; set; }
        /// <summary>
        /// Id Number of Corresponding Budget
        /// </summary>
        public int BudgetId { get; set; }
        /// <summary>
        /// When This Transaction Took Place
        /// </summary>
        public DateTimeOffset Created { get; set; }
    }
}