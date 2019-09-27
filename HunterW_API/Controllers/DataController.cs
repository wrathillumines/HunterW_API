using HunterW_API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using RouteAttribute = System.Web.Http.RouteAttribute;
using RoutePrefixAttribute = System.Web.Http.RoutePrefixAttribute;

namespace HunterW_API.Controllers
{
    /// <summary>
    /// Tacos
    /// </summary>
    [RoutePrefix("api/Data")]
    public class DataController : ApiController
    {
        private ApiDbContext db = new ApiDbContext();

        /// <summary>
        /// Get all household records from the database
        /// </summary>
        /// <returns>Household object</returns>
        [Route("GetHousehold")]
        public async Task<List<Household>> GetHousehold()
        {
            return await db.GetHousehold();
        }

        /// <summary>
        /// Get all budget records from the database
        /// </summary>
        /// <param name="householdId">Foreign Key to Household</param>
        /// <returns>Budget object</returns>
        [Route("GetBudgets")]
        public async Task<List<Budget>> GetBudgets(int householdId)
        {
            return await db.GetBudgets(householdId);
        }

        /// <summary>
        /// Get specific budget details from the database
        /// </summary>
        /// <param name="id">Primary Key of Budget</param>
        /// <returns>Budget object</returns>
        [Route("GetBudgetDetails")]
        public async Task<Budget> GetBudgetDetails(int id)
        {
            return await db.GetBudgetDetails(id);
        }

        /// <summary>
        /// Get all budget item records from the database
        /// </summary>
        /// <returns>BudgetItem object</returns>
        [Route("GetBudgetItems")]
        public async Task<List<BudgetItem>> GetBudgetItems()
        {
            return await db.GetBudgetItems();
        }

        /// <summary>
        /// Get specific budget item details from the database
        /// </summary>
        /// <param name="Id">Primary Key of Budget Item</param>
        /// <returns>BudgetItem object</returns>
        [Route("GetBudgetItemDetails")]
        public async Task<BudgetItem> GetBudgetItemDetails(int Id)
        {
            return await db.GetBudgetItemDetails(Id);
        }

        /// <summary>
        /// Get all bank account records from the database
        /// </summary>
        /// <returns>BankAccount object</returns>
        [Route("GetAccounts")]
        public async Task<List<BankAccount>> GetAccounts()
        {
            return await db.GetAccounts();
        }

        /// <summary>
        /// Get specific budget item details from the database
        /// </summary>
        /// <param name="Id">Primary Key of Bank Account</param>
        /// <returns>BudgetItem object</returns>
        [Route("GetAccountDetails")]
        public async Task<BankAccount> GetAccountDetails(int Id)
        {
            return await db.GetAccountDetails(Id);
        }

        /// <summary>
        /// Get all transaction records from the database
        /// </summary>
        /// <returns>Transaction object</returns>
        [Route("GetTransactions")]
        public async Task<List<Transaction>> GetTransactions()
        {
            return await db.GetTransactions();
        }

        /// <summary>
        /// Get specific transaction item details from the database
        /// </summary>
        /// <param name="transactionId">Foreign Key to Transaction</param>
        /// <returns>TransactionItem object</returns>
        [Route("GetTransactionDetails")]
        public async Task<Transaction> GetTransactionDetails(int transactionId)
        {
            return await db.GetTransactionDetails(transactionId);
        }

        /// <summary>
        /// Post new bank account to the database
        /// </summary>
        /// <param name="householdId">Foreign Key to Household</param>
        /// <param name="bankAccountTypeId">Foreign Key to Account Type</param>
        /// <param name="name">Name of Bank Account</param>
        /// <param name="balance">Starting Balance for Account</param>
        /// <param name="lowAlertLevel">Level at Which to Notify User of Low Funds</param>
        /// <returns>BankAccount object</returns>
        [Route("AddAccount")]
        public async Task<int> AddAccount(
            int householdId,
            int bankAccountTypeId,
            string name,
            double balance,
            double lowAlertLevel)
        {
            return await db.AddAccount(
                householdId,
                bankAccountTypeId,
                name,
                balance,
                lowAlertLevel);
        }

        /// <summary>
        /// Post new budget to the database
        /// </summary>
        /// <param name="name">Name of Budget</param>
        /// <param name="description">Information About Budget</param>
        /// <param name="householdId">Foreign Key to Household</param>
        /// <returns>Budget object</returns>
        [Route("AddBudget")]
        public async Task<int> AddBudget(
            string name,
            string description,
            int householdId)
        {
            return await db.AddBudget(
                name,
                description,
                householdId);
        }

        /// <summary>
        /// Post new transaction to the database
        /// </summary>
        /// <param name="name">Name of Transaction</param>
        /// <param name="description">Information About Transaction</param>
        /// <param name="transactionAmount">Amount of Money Exchanged in Transaction</param>
        /// <param name="bankAccountsId">Foreign Key to Bank Account</param>
        /// <param name="transactionTypeId">Foreign Key to Transaction Type</param>
        /// <param name="budgetId">Foreign Key to Budget</param>
        /// <param name="createdById">Foreign Key to User Who Made Transaction</param>
        /// <returns>Transaction object</returns>
        [Route("AddTransaction")]
        public async Task<int> AddTransaction(
            string name,
            string description,
            double transactionAmount,
            int bankAccountsId,
            int transactionTypeId,
            int budgetId,
            string createdById)
        {
            return await db.AddTransaction(
                name,
                description,
                transactionAmount,
                bankAccountsId,
                transactionTypeId,
                budgetId,
                createdById);
        }
    }
}