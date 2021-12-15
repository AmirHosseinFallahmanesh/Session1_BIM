using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        CustomerRepository repo;
        public CustomerController()
        {
            context = new CustomerRepository();

        }
        [HttpGet]
        public List<Customer> GetAll()
        
        {
            return context.Customers.ToList();
        }


        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            return context.Customers.Find(id); 
        }

        [HttpPost]
        public int Post(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return customer.CustomerId;
        }

        [HttpPut]
        public Customer Put(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
            return customer;
          
        }

        [HttpDelete]
        public void Delete([FromBody]int id)
        {
            context.Customers.Remove(new Customer() { CustomerId = id });
            context.SaveChanges();
        }
    }
}