using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HunterW_API.Models
{
    /// <summary>
    /// Groups That Users Are In to Share Budgets and Accounts
    /// </summary>
    public class Household
    {
        /// <summary>
        /// Id Number
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of Household
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Information About Household
        /// </summary>
        public string Description { get; set; }
    }
}