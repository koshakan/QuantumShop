using QuantumShop.Models;

namespace QuantumShop.Data.Repositories
{
    public interface ICustomerRepository
    {
        Customer GetCategory(int Id);
        Customer AddCustomer(Customer cus);
        Customer DeleteCustomer(Customer cus);
        
    }
}