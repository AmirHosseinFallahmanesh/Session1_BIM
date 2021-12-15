using System.Collections.Generic;
using System.Linq;

namespace Demo1.Model
{
    public class CustomerRepository
    {

        MyContext context;
        public CustomerRepository()
        {
            context = new MyContext();

        }
        public IEnumerable<Customer> GetAll()
        {
            return context.Customers.ToList();
        }


        public Customer GetCustomer(int id)
        {

            return context.Customers.Find(id);
        }


        public int Add(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer.CustomerId;

        }

        public Customer Update(Customer customer )
        {
            context.Customers.Update(customer);
            context.SaveChanges();
            return customer;
        }
      
        public void Delete(int id)
        {
            context.Customers.Remove(new Customer() { CustomerId = id });
            context.SaveChanges();
        }
    }
}
