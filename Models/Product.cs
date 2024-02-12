namespace FinancialTamkeen_BlogAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public  double  Price { get; set; }
        public int QuantityInStock { get; set; }

    }
}