﻿using Microsoft.EntityFrameworkCore;

namespace All_Prime_Techologies_Ltd.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) 
        { }

       // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       // {
         //   base.OnConfiguring(optionsBuilder);
         //   optionsBuilder.UseSqlServer("Server=.\\SqlExpress;Database=All_Prime_Techologies_Ltd;Trusted_Connection =True;TrustServerCertificate=true;");
       // }
        //public DbSet<Employee> Employees { get; set; }

        public DbSet<Employee> Employees => Set<Employee>();
    }
    
}
