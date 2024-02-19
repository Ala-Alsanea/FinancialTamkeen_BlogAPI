using FinancialTamkeen_BlogAPI.Models;

namespace FinancialTamkeen_BlogAPI.interfaces.Repositories
{
    public interface IProductRepository
    {
        public bool ProductExists(int id);
        ICollection<Product> All();
        Product GetById(int id);
        bool Create(Product product);
        bool Update(Product product);


    }
}