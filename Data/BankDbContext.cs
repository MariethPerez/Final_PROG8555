using Microsoft.EntityFrameworkCore;
using bank.Models;
using bank.Models.Enums;

namespace bank.Data
{
    public class BankDbContext: DbContext
    {
        public BankDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
    }
}



