using Microsoft.EntityFrameworkCore;
using Store.Entity;

namespace Store.Data
{
    public class DataContaxt : DbContext
    {
        public DataContaxt(DbContextOptions options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
