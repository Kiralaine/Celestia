using Microsoft.EntityFrameworkCore;
using Celestia.DataAcess.EntityConfiguration;
using Celestia.DataAccess.Entities;
namespace Celestia.DataAcess
{
    public class MainContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        }
    }
}
