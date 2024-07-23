using Assignment_2.Dtos;
using Assignment_2.Entities;
using Assignment_2.Interfaces;

namespace Assignment_2.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;
        private readonly IMapper _mapper;


        public List<CustomerDto> GetAllCustomers()
        {
            var customers = _customerRepo.GetAllCustomers();
            return _mapper.Map<List<CustomerDto>>(customers);
        }

        public CustomerDto GetCustomerById(int id)
        {
            var customer = _customerRepo.GetCustomerById(id);
            return _mapper.Map<CustomerDto>(customer);
        }

        public void AddCustomer(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            _customerRepo.AddCustomer(customer);
        }

        public void UpdateCustomer(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            _customerRepo.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            _customerRepo.DeleteCustomer(id);
        }
    }
}
