using QuantumShop.Models;

namespace QuantumShop.Data.Repositories
{
    internal interface ICategoryRepository
    {
        Category GetCategory(int Id);
        Category AddCategory(Category cat);
        Category ClearCategory(Category cat);
    }
}