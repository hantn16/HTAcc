using HTA.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HTA.Model
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
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<ContractApendix> ContractApendixes { get; set; }
        public virtual DbSet<Contractor> Contractors { get; set; }
        public virtual DbSet<PaymentPeriod> PaymentPeriods { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Work> Works { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<CostType> CostTypes { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }

    }
}
