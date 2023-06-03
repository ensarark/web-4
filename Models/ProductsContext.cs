using Microsoft.EntityFrameworkCore;

namespace dotnetodev.Models {
    public class ProductsContext : DbContext {
        public ProductsContext() { }
        public ProductsContext(DbContextOptions<ProductsContext> options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-ARHM7BLJ\\SQLEXPRESS;Initial Catalog=DBProdcuts; User Id=sa;Password=123;TrustServerCertificate=True");
        }
     
        public DbSet<Products> EntityNames { get; set; }
    }
}