using Assignment_2.Entities;

namespace Assignment_2.Interfaces
{
    public interface ICustomerRepo
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int id);
        void AddCustomer(object customer);
        void UpdateCustomer(object customer);
    }
}
