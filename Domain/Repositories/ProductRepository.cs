

using FinancialTamkeen_BlogAPI.Domain.Data;
using FinancialTamkeen_BlogAPI.Domain.Models;
using FinancialTamkeen_BlogAPI.Domain.Repositories.interfaces;

namespace FinancialTamkeen_BlogAPI.Domain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext context;

        public ProductRepository(DataContext context)
        {
            this.context = context;
        }
        public bool ProductExists(int id)
        {
            return this.context.Products.Any(c => c.ProductId == id);
        }
        public ICollection<Product> All()
        {
            return this.context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return this.context.Products.Find(id);
        }

        public bool Create(Product product)
        {
            this.context.Products.Add(product);
            return this.context.SaveChanges() > 0 ? true : false;
        }


        public bool Update(Product product)
        {
            this.context.Update(product);
            return this.context.SaveChanges() > 0 ? true : false;
        }
    }
}