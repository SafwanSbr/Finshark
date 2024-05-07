using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }
        
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Stock> Stocks { get; set; }
    }
}
