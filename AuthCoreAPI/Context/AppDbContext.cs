using AuthCoreAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace AuthCoreAPI.Context
{
    public class AppDbContext :  DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> SolicitacaoProjeto { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<User>().HasKey(c => c.Id);
        }
    }
}
