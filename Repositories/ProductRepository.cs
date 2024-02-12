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


        public bool Update(int id,Product product)
        {
            var existingProduct = this.context.Products.Find(id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Description = product.Description;
                existingProduct.QuantityInStock = product.QuantityInStock ;
                // Update other properties as needed
                this.context.Products.Update(existingProduct);
                return this.context.SaveChanges() > 0;
            }
            return false;
        }
    }
}