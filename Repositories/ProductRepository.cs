using FinancialTamkeen_BlogAPI.Data;
using FinancialTamkeen_BlogAPI.interfaces.Repositories;
using FinancialTamkeen_BlogAPI.Models;

namespace FinancialTamkeen_BlogAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext context;

        public ProductRepository(DataContext context)
        {
            this.context = context;
        }
        public ICollection<Product> All()
        {
            return this.context.Products.ToList();
        }
        public Product GetById(int id)
        {
            return this.context.Products.Find(id);
        }

        public void Create(Product product)
        {
            this.context.Products.Add(product);
        }


        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}