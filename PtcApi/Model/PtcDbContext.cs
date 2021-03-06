using Microsoft.EntityFrameworkCore;

namespace PtcApi.Model
{
    public class PtcDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        // private const string CONN =
        //               @"Server=Localhost;
        //                 Database=PTC-Pluralsight;
        //                 Trusted_Connection=True;
        //                 MultipleActiveResultSets=true";

        private const string CONN = @"Server=(localdb)\MSSQLLocalDB;
    Database=PTC-Pluralsight;
    AttachDbFilename=C:\Repos\GitHub\Pluralsight\Angular Security with JWT\SampleProject\SqlData\PTC-Pluralsight.mdf;
    MultipleActiveResultSets=true";

        protected override void OnConfiguring(
                    DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(CONN);
        }
    }
}
