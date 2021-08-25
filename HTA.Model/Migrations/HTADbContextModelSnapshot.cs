﻿// <auto-generated />
using System;
using HTA.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HTA.Model.Migrations
{
    [DbContext(typeof(HTADbContext))]
    partial class HTADbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HTA.Model.Models.Contract", b =>
                {
                    b.Property<int>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContractContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ContractOriginValue")
                        .HasColumnType("float");

                    b.Property<int>("ContractorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SigningDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("TerminateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("WorkId")
                        .HasColumnType("int");

                    b.HasKey("ContractId");

                    b.HasIndex("ContractorId");

                    b.HasIndex("ProjectId");

                    b.HasIndex("WorkId");

                    b.ToTable("Contract");
                });

            modelBuilder.Entity("HTA.Model.Models.ContractApendix", b =>
                {
                    b.Property<int>("ContractApendixId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("AdjustedValue")
                        .HasColumnType("float");

                    b.Property<string>("ContractApendixName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.HasKey("ContractApendixId");

                    b.HasIndex("ContractId");

                    b.ToTable("ContractApendix");
                });

            modelBuilder.Entity("HTA.Model.Models.Contractor", b =>
                {
                    b.Property<int>("ContractorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankAccountNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractorCode")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("ContractorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Representative")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxCode")
                        .HasMaxLength(14)
                        .HasColumnType("nvarchar(14)");

                    b.HasKey("ContractorId");

                    b.ToTable("Contractor");
                });

            modelBuilder.Entity("HTA.Model.Models.CostType", b =>
                {
                    b.Property<int>("CostTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CostTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CostTypeId");

                    b.ToTable("CostType");
                });

            modelBuilder.Entity("HTA.Model.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvoiceNo")
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaymentPeriodId")
                        .HasColumnType("int");

                    b.Property<double>("PretaxValue")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("VatValue")
                        .HasColumnType("float");

                    b.HasKey("InvoiceId");

                    b.HasIndex("PaymentPeriodId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("HTA.Model.Models.PaymentPeriod", b =>
                {
                    b.Property<int>("PaymentPeriodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("AcceptedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaidDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("ValueAccepted")
                        .HasColumnType("float");

                    b.Property<double>("ValuePaid")
                        .HasColumnType("float");

                    b.Property<double>("ValueRequested")
                        .HasColumnType("float");

                    b.HasKey("PaymentPeriodId");

                    b.HasIndex("ContractId");

                    b.HasIndex("PaymentTypeId");

                    b.ToTable("PaymentPeriod");
                });

            modelBuilder.Entity("HTA.Model.Models.PaymentType", b =>
                {
                    b.Property<int>("PaymentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentTypeId");

                    b.ToTable("PaymentType");
                });

            modelBuilder.Entity("HTA.Model.Models.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectId");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("HTA.Model.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("HTA.Model.Models.Work", b =>
                {
                    b.Property<int>("WorkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CostTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentWorkId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("WorkId");

                    b.HasIndex("CostTypeId");

                    b.HasIndex("ParentWorkId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Work");
                });

            modelBuilder.Entity("HTA.Model.Models.Contract", b =>
                {
                    b.HasOne("HTA.Model.Models.Contractor", "Contractor")
                        .WithMany("Contracts")
                        .HasForeignKey("ContractorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HTA.Model.Models.Project", null)
                        .WithMany("Contracts")
                        .HasForeignKey("ProjectId");

                    b.HasOne("HTA.Model.Models.Work", "Work")
                        .WithMany("Contracts")
                        .HasForeignKey("WorkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contractor");

                    b.Navigation("Work");
                });

            modelBuilder.Entity("HTA.Model.Models.ContractApendix", b =>
                {
                    b.HasOne("HTA.Model.Models.Contract", "Contract")
                        .WithMany("ContractApendixes")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");
                });

            modelBuilder.Entity("HTA.Model.Models.Invoice", b =>
                {
                    b.HasOne("HTA.Model.Models.PaymentPeriod", "PaymentPeriod")
                        .WithMany("Invoices")
                        .HasForeignKey("PaymentPeriodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentPeriod");
                });

            modelBuilder.Entity("HTA.Model.Models.PaymentPeriod", b =>
                {
                    b.HasOne("HTA.Model.Models.Contract", "Contract")
                        .WithMany("PaymentPeriods")
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HTA.Model.Models.PaymentType", "PaymentType")
                        .WithMany("PaymentPeriods")
                        .HasForeignKey("PaymentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contract");

                    b.Navigation("PaymentType");
                });

            modelBuilder.Entity("HTA.Model.Models.Work", b =>
                {
                    b.HasOne("HTA.Model.Models.CostType", "CostType")
                        .WithMany("Works")
                        .HasForeignKey("CostTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HTA.Model.Models.Work", "ParentWork")
                        .WithMany("ChildWorks")
                        .HasForeignKey("ParentWorkId");

                    b.HasOne("HTA.Model.Models.Project", "Project")
                        .WithMany("Works")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CostType");

                    b.Navigation("ParentWork");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("HTA.Model.Models.Contract", b =>
                {
                    b.Navigation("ContractApendixes");

                    b.Navigation("PaymentPeriods");
                });

            modelBuilder.Entity("HTA.Model.Models.Contractor", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("HTA.Model.Models.CostType", b =>
                {
                    b.Navigation("Works");
                });

            modelBuilder.Entity("HTA.Model.Models.PaymentPeriod", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("HTA.Model.Models.PaymentType", b =>
                {
                    b.Navigation("PaymentPeriods");
                });

            modelBuilder.Entity("HTA.Model.Models.Project", b =>
                {
                    b.Navigation("Contracts");

                    b.Navigation("Works");
                });

            modelBuilder.Entity("HTA.Model.Models.Work", b =>
                {
                    b.Navigation("ChildWorks");

                    b.Navigation("Contracts");
                });
#pragma warning restore 612, 618
        }
    }
}