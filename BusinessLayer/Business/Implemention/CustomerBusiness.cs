using CustomerApi.BusinessLayer.Business.Interface;
using CustomerApi.BusinessLayer.ExceptionManagment.Exception;
using CustomerApi.DataLayer.Models.Context;
using CustomerApi.DataLayer.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CustomerApi.BusinessLayer.Business.Implemention
{
    public class CustomerBusiness : ICustomer
    {
        CustomerDbContext _dbContext;
        public CustomerBusiness(CustomerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Delete(int ID)
        {
           var item=  _dbContext.Customers.Find(ID);
            if (item == null)
                return 0;
            _dbContext.Customers.Remove(item);
            _dbContext.SaveChanges();
            return 1;
        }
        public List<Customer> Find(string internationalCode)
        {
            return _dbContext.Customers.Where(e=>e.InternationalCode.Contains(internationalCode.Trim())).ToList();
        }
        public int Insert(Customer customer)
        {
            Validate(customer);
            var n = _dbContext.Customers.Add(customer);
            _dbContext.SaveChanges();
            return n.Entity.ID;
        }
        public List<Customer> SelectAll()
        {
            return _dbContext.Customers.ToList();

        }
        public int Update(Customer customer)
        {
            Validate(customer);
            _dbContext.Customers.Update(customer);
            _dbContext.SaveChanges();
            return 1;
        }
        void Validate(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.Name))
                throw new InvalidNameException();
            else if (string.IsNullOrEmpty(customer.LastName))
                throw new InvalidLastNameException();
        }
    }
}
