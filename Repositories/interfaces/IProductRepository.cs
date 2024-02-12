using FinancialTamkeen_BlogAPI.Models;

namespace FinancialTamkeen_BlogAPI.interfaces.Repositories
{
    public interface IProductRepository
    {
        ICollection<Product> All();
        Product GetById(int id);
        void Create(Product product);
        void Update(Product product);

    }
}