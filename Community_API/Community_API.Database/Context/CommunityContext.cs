using Community_API.Database.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Community_API.Database.Context
{
    public class CommunityContext : DbContext
    {

        public DbSet<Community> Community { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-PRM8AD3;Database=TestDB;Trusted_Connection=True;");
        }
    }
}