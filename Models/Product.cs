namespace FinancialTamkeen_BlogAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public  string Name { get; set; }
        public  string Description { get; set; }
        public  double  Price { get; set; }
        public int QuantityInStock { get; set; }

    }
}