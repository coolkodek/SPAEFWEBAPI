
using POCOModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{        
    public interface ICustomerServices
    {
        Customer GetCustomerById(int customerId);
        IEnumerable<Customer> GetAllCustomers();
        int CreateCustomer(Customer customerEntity);
        bool UpdateCustomer(int customerId, Customer customerEntity);
        bool DeleteCustomer(int customerId);
    }
}
