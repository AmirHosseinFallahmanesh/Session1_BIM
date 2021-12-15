using System;
using System.Threading.Tasks;

namespace Demo1.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
    }
}
