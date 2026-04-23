using bank.Models;

namespace bank.Repository
{
    public interface ICustomerRepository
    {
        //CRUD operations for Customer
        public void Add(Customer obj);
        public void Delete(int id);
         public void Update(Customer obj);
        public Customer GetById(int id);
        public List<Customer> GetAll();
        public void Save();
    }
}