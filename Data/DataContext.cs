using Microsoft.EntityFrameworkCore;
using FinancialTamkeen_BlogAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FinancialTamkeen_BlogAPI.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

    }
}