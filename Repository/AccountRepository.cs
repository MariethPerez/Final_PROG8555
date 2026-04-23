using bank.Data;
using bank.Models;

namespace bank.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public BankDbContext Context { get; }

        public AccountRepository(BankDbContext context)
        {
            Context = context;
        }
        public void Add(Account obj)
        {
            Context.Accounts.Add(obj);
        }
        public void Delete(int id)
        {
            var account = Context.Accounts.Find(id);
            if (account != null)
            {
                Context.Accounts.Remove(account);
            }
        }
        public  void Update(Account obj)
        {
            Context.Accounts.Update(obj);
        }
        public Account GetById(int id)
        {
            return Context.Accounts.Find(id);
        }
        public List<Account> GetAll()
        {
            return Context.Accounts.ToList();
        }
        public void Save()
        {
            Context.SaveChanges();
        }
    }
    }