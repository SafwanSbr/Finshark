using api.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class DataContext: IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }
        
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }

        public DbSet<CompanyIncomeStatement> companyIncomeStatements { get; set; }
        public DbSet<CompanyBalanceSheet> companyBalanceSheets { get; set; }
        public DbSet<CompanyCashFlow> companyCashFlows { get; set; }
        public DbSet<CompanyKeyMetrics> companyKeyMetrics { get; set; }
        public DbSet<CompanyTenK> companyTenKs { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Portfolio>(x => x.HasKey(p => new
            {
                p.AppUserID, p.StockId
            }));

            //A Portfolio has Many Stock
            builder.Entity<Portfolio>()
                .HasOne(u => u.Stock)
                .WithMany(u => u.Portfolios)
                .HasForeignKey(u => u.StockId);

            //A Portfolio has Many User
            builder.Entity<Portfolio>()
                .HasOne(u => u.AppUser)
                .WithMany(u => u.portfolios)
                .HasForeignKey(p => p.AppUserID);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER"
                },
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
