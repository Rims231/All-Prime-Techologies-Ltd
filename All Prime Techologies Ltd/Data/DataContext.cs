using Microsoft.EntityFrameworkCore;

namespace All_Prime_Techologies_Ltd.Data
{
    
        public class DataContext : DbContext
        {
            public DataContext(DbContextOptions<DataContext> options) : base(options)
            {

            }
            public DbSet<Employee> Employees => Set<Employee>();
            //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //{
            // base.OnConfiguring(optionsBuilder);
            // optionsBuilder.UseSqlServer("Server=.\\SqlExpress; Database=Project; Trusted_Connect=true TrustedServerCertificate=true;");
            //}
        }
    
}
