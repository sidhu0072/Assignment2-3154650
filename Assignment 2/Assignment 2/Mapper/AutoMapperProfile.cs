using Assignment_2.Dtos;
using Assignment_2.Entities;

namespace Assignment_2.Mapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CustomerDto, Customer>();
        }

        private void CreateMap<T1, T2>()
        {
            throw new NotImplementedException();
        }
    }
}