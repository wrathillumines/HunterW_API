using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace HunterW_API.Models
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext()
            : base("DefaultConnection")
        { }

        public static ApiDbContext Create()
        {
            return new ApiDbContext();
        }

        //Communicate with individual tables in the DB
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<BudgetItem> BudgetItems { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Household> Households { get; set; }

        //Execute stored procedures
        public async Task<List<Household>> GetHousehold()
        {
            return await Database.SqlQuery<Household>("GetHousehold").ToListAsync();
        }

        public async Task<List<Budget>> GetBudgets(int householdId)
        {
            //return await Database.SqlQuery<Budget>("GetBudgets").ToListAsync(householdId);
            return await Database.SqlQuery<Budget>("GetBudgets @houseId", new SqlParameter("houseId", householdId)).ToListAsync();
        }

        public async Task<Budget> GetBudgetDetails(int budgetId)
        {
            return await Database.SqlQuery<Budget>("GetBudgetDetails @budgetId",
                new SqlParameter("budgetId", budgetId)).FirstOrDefaultAsync();
        }

        public async Task<List<BudgetItem>> GetBudgetItems()
        {
            return await Database.SqlQuery<BudgetItem>("GetBudgetItems").ToListAsync();
        }

        public async Task<BudgetItem> GetBudgetItemDetails(int Id)
        {
            return await Database.SqlQuery<BudgetItem>("GetBudgetItemDetails @Id",
                new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }

        public async Task<List<BankAccount>> GetAccounts()
        {
            return await Database.SqlQuery<BankAccount>("GetAccounts").ToListAsync();
        }

        public async Task<BankAccount> GetAccountDetails(int Id)
        {
            return await Database.SqlQuery<BankAccount>("GetAccountDetails @Id",
                new SqlParameter("Id", Id)).FirstOrDefaultAsync();
        }

        public async Task<List<Transaction>> GetTransactions()
        {
            return await Database.SqlQuery<Transaction>("GetTransactions").ToListAsync();
        }

        public async Task<Transaction> GetTransactionDetails(int transactionId)
        {
            return await Database.SqlQuery<Transaction>("GetTransactionDetails @transactionId",
                new SqlParameter("transactionId", transactionId)).FirstOrDefaultAsync();
        }

        public async Task<int> AddAccount(
            int householdId,
            int bankAccountId,
            string name,
            double balance,
            double lowAlertLevel)
        {
            return await Database.ExecuteSqlCommandAsync(
                "AddAccount @householdId, @bankAccountId, @name, @balance, @lowAlertLevel",
                new SqlParameter("@householdId", householdId),
                new SqlParameter("@bankAccountId", bankAccountId),
                new SqlParameter("@name", name),
                new SqlParameter("@balance", balance),
                new SqlParameter("@lowAlertLevel", lowAlertLevel));
        }

        public async Task<int> AddBudget(
            string name,
            string description,
            int householdId)
        {
            return await Database.ExecuteSqlCommandAsync(
                "AddBudget @name, @description, @householdId",
                new SqlParameter("@name", name),
                new SqlParameter("@description", description),
                new SqlParameter("@householdId", householdId));
        }

        public async Task<int> AddTransaction(
            string name,
            string description,
            double transactionAmount,
            int bankAccountsId,
            int transactionTypeId,
            int budgetId,
            string createdById)
        {
            return await Database.ExecuteSqlCommandAsync(
                "AddTransaction @name, @description, @transactionAmount, @bankAccountsId, @transactionTypeId, @budgetId, @createdById",
                new SqlParameter("@name", name),
                new SqlParameter("@description", description),
                new SqlParameter("@transactionAmount", transactionAmount),
                new SqlParameter("bankAccountsId", bankAccountsId),
                new SqlParameter("@transactionTypeId", transactionTypeId),
                new SqlParameter("@budgetId", budgetId),
                new SqlParameter("@createdById", createdById));
        }
    }
}