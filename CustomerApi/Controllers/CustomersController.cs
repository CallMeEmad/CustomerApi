using AutoMapper;
using CustomerApi.BusinessLayer.Business.Interface;
using CustomerApi.DataLayer.Models.Entities;
using CustomerApi.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {

        ICustomer _customer;
        private readonly IMapper _mapper;
        public CustomersController(ICustomer customer, IMapper mapper)
        {
            _customer = customer;
            _mapper = mapper;
        }

        [HttpGet]
        public List<CustomerDto> Get(string internationalCode)
        {
            List<CustomerDto> result;
            if (string.IsNullOrWhiteSpace(internationalCode))
                result = _mapper.Map<List<CustomerDto>>(_customer.SelectAll());
            else
                result = _mapper.Map<List<CustomerDto>>(_customer.Find(internationalCode));

            return result;
        }

        [HttpPost]
        public int Insert(CustomerDto customer)
        {
            var customerModel = _mapper.Map<Customer>(customer);
            int result = _customer.Insert(customerModel);
            return result;
        }

        [HttpDelete]
        public int Delete(int id)
        {
            int result = _customer.Delete(id);
            return result;
        }

        [HttpPut]
        public int Update(CustomerDto customer)
        {
            var customerModel = _mapper.Map<Customer>(customer);
            var result = _customer.Update(customerModel);
            return result;
        }

    }
}
