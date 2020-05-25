using QuantumShop.Data.Data;
using QuantumShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuantumShop.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {

        private ApplicationDbContext _con;

        public CustomerRepository(ApplicationDbContext con)
        {
            _con = con;
        }

        public Customer GetCustomer(int Id)
        {
            return _con.Customers.Find(Id);
        }

        public Customer AddCustomer(Customer cus)
        {
           _con.Customers.Add(cus);
           _con.SaveChanges();
            return cus;
        }

        public Customer DeleteCustomer(Customer cus) 
        {
            _con.Customers.Remove(cus);
            _con.SaveChanges();
            return cus;
        }
    }
}
