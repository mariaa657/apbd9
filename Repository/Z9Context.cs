using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using z9.Models;

namespace Repository
{
    public class Z9Context :  DbContext 
    {
        public Z9Context()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Persist Security Info=False;Integrated Security=true; Initial Catalog=2019SBD;Server=db-mssql;Encrypt=True; TrustServerCertificate=True;");
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductsCategories> ProductsCategories { get; set; }
    }
}