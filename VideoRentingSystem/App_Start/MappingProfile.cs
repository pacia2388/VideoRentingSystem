using AutoMapper;
using VideoRentingSystem.Dtos;
using VideoRentingSystem.Models;

namespace VideoRentingSystem.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}