using bank.Models;

namespace bank.Repository
{
    public interface ITransactionRepository
    {
        //CRUD operations for Customer
        public void Add(Transaction obj);
        public void Delete(int id);
         public void Update(Transaction obj);
        public Transaction GetById(int id);
        public List<Transaction> GetAll();
        public void Save();
    }
}