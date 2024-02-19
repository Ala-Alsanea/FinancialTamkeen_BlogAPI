
using FinancialTamkeen_BlogAPI.Domain.Models;

namespace FinancialTamkeen_BlogAPI.Domain.Repositories.interfaces
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