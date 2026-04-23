using bank.Models;

namespace bank.Repository
{
    public interface IAccountRepository
    {
        //CRUD operations for Customer
        public void Add(Account obj);
        public void Delete(int id);
         public void Update(Account obj);
        public Account GetById(int id);
        public List<Account> GetAll();
        public void Save();

        public Account GetAccountById(int id);
    }
}