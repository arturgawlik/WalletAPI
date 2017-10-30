using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EF
{
    public class WalletContext : DbContext
    {
        public DbSet<User> Users { set; get; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Event> Events { get; set; }
    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;User Id=SA;Password=Toshiba321321!; Database=Wallet");
        }
    
    }
}