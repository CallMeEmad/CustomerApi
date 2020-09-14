using CustomerApi.DataLayer.Models.Entities;
using System.Collections.Generic;

namespace CustomerApi.BusinessLayer.Business.Interface
{
    public interface ICustomer
    {
        int Insert(Customer customer);
        int Delete(int ID);
        int Update(Customer customer);
        List<Customer> SelectAll();
        List<Customer> Find(string internationalCode);
    }
}
