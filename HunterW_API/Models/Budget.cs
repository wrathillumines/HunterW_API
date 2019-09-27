using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HunterW_API.Models
{
    /// <summary>
    /// Money Set Aside for General Categories
    /// </summary>
    public class Budget
    {
        /// <summary>
        /// Id Number
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Id Number of Corresponding Household
        /// </summary>
        public int? HouseholdId { get; set; }
        /// <summary>
        /// Name of Budget
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Information About Budget
        /// </summary>
        public string Description { get; set; }
    }
}