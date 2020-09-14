using AutoMapper;
using CustomerApi.DataLayer.Models.Entities;
using CustomerApi.Model;


namespace CustomerApi.MapperProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerDto, Customer>();
            CreateMap<Customer, CustomerDto>();
        }
    }
}
