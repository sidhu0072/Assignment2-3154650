using Assignment_2.Dtos;
using Assignment_2.Entities;

internal interface IMapper
{
    T Map<T>(List<Customer> customers);
    T Map<T>(Customer customer);
    object Map<T>(CustomerDto customerDto);
}