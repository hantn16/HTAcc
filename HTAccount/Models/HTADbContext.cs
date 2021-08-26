using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HTAccount.Models
{
   public class HTADbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=HTAccountDb;Trusted_Connection=True;");
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractApendix> ContractApendixes { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<PaymentPeriod> PaymentPeriods { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<CostType> CostTypes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

    }
}
