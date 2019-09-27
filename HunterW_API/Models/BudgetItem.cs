using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HunterW_API.Models
{
    /// <summary>
    /// Specific Payments Corresponding to Budgets
    /// </summary>
    public class BudgetItem
    {
        /// <summary>
        /// Id Number
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id Number of Corresponding Budget
        /// </summary>
        public int BudgetId { get; set; }
        /// <summary>
        /// Name of Item
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Information About Item
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Amount of Money Set Aside For This
        /// </summary>
        public double Amount { get; set; }
        /// <summary>
        /// Who The Money Goes To
        /// </summary>
        public string Payee { get; set; }
    }
}