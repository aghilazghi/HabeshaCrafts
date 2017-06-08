using System.Data.Entity;

namespace HabeshaCrafts.Models
{
    public class HabeshaCraftsContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}