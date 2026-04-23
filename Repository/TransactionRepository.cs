using bank.Data;
using bank.Models;

namespace bank.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        public BankDbContext Context { get; }

        public TransactionRepository(BankDbContext context)
        {
            Context = context;
        }
        public void Add(Transaction obj)
        {
            Context.Transactions.Add(obj);
        }
        public void Delete(int id)
        {
            var customer = Context.Transactions.Find(id);
            if (customer != null)
            {
                Context.Transactions.Remove(customer);
            }
        }
        public  void Update(Transaction obj)
        {
            Context.Transactions.Update(obj);
        }
        public Transaction GetById(int id)
        {
            return Context.Transactions.Find(id);
        }
        public List<Transaction> GetAll()
        {
            return Context.Transactions.ToList();
        }
        public void Save()
        {
            Context.SaveChanges();
        }

        public  List<Transaction> GetTransactionsByAccountId(int id)
        {
            return await Context.Transactions
                .Where(t => t.AccountId == id)
                .OrderByDescending(t => t.TransactionDate)
                .ToListAsync();
        }
    }
    }