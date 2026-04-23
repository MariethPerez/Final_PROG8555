using bank.Data;
using bank.Models;

namespace bank.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        public BankDbContext Context { get; }

        public CustomerRepository(BankDbContext context)
        {
            Context = context;
        }
        public void Add(Customer obj)
        {
            Context.Customers.Add(obj);
        }
        public void Delete(int id)
        {
            var customer = Context.Customers.Find(id);
            if (customer != null)
            {
                Context.Customers.Remove(customer);
            }
        }
        public  void Update(Customer obj)
        {
            Context.Customers.Update(obj);
        }
        public Customer GetById(int id)
        {
            return Context.Customers.Find(id);
        }
        public List<Customer> GetAll()
        {
            return Context.Customers.ToList();
        }
        public void Save()
        {
            Context.SaveChanges();
        }
    }
    }