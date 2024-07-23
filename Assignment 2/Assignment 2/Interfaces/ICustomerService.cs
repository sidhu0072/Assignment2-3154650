using Assignment_2.Dtos;
namespace Assignment_2.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerDto> GetAllCustomers();
        CustomerDto GetCustomerById(int id);
        void AddCustomer(CustomerDto customerDto);
        void UpdateCustomer(CustomerDto customerDto);
        void DeleteCustomer(int id);
    }
}
