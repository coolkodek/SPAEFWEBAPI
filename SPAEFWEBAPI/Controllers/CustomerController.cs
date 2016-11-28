
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataModel.GenericRepository;
using POCOModels.Models;


namespace SPAEFWEBAPI.Controllers
{
    public class CustomerController : ApiController
    {

       // private IRepository<Customer> repository;
        private readonly UnitOfWork _unitOfWork;

        public CustomerController()
        {
            // this.repository = new GenericRepository<Customer>(new CustomerDBContext());
            _unitOfWork = new UnitOfWork();
        }

        // GET api/<controller>
        public IEnumerable<Customer> Get()
        {
           // CustomerDBContext customersdb = new CustomerDBContext();
           // return customersdb.Customers;
       
            //return repository.GetAll();
            return _unitOfWork.CustomerRepository.GetAll();
        }

        // POST api/<controller>
        public void Post([FromBody]Customer customer)
        {
            //CustomerDBContext customersdb = new CustomerDBContext();
            //customersdb.Customers.Add(customer);
            //customersdb.SaveChanges();
         
            // repository.Insert(customer);
           // repository.Save();
            _unitOfWork.CustomerRepository.Insert(customer);
            _unitOfWork.Save();
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Customer customer)
        {
            //CustomerDBContext customersdb = new CustomerDBContext();
            //Customer customerToRemove = customersdb.Customers.Find(customer.id);

            //customersdb.Customers.Remove(customerToRemove);
            //Customer updatedCustomer = customer;
            //customersdb.Customers.Add(updatedCustomer);

            //customersdb.SaveChanges();
           // repository.Update(id, customer);
           // repository.Save();

            _unitOfWork.CustomerRepository.Update(id,customer);
            _unitOfWork.Save();
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
           
            //CustomerDBContext customersdb = new CustomerDBContext();
            //Customer cust = customersdb.Customers.Find(id);
            //customersdb.Customers.Remove(cust);
            //customersdb.SaveChanges();

            // repository.Delete(Convert.ToInt32(id));

            _unitOfWork.CustomerRepository.Delete(Convert.ToInt32(id));
        }
    }
}
