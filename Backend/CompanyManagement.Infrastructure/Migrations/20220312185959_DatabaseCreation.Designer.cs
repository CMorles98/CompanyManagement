﻿// <auto-generated />
using System;
using CompanyManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CompanyManagement.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220312185959_DatabaseCreation")]
    partial class DatabaseCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CompanyManagement.Domain.Entities.Division", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DivisionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("CompanyManagement.Domain.Entities.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("CompanyManagement.Domain.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Positions");
                });

            modelBuilder.Entity("CompanyManagement.Domain.Entities.Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BaseSalary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("BeginDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Commission")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("CompensationBonus")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Contributions")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("DivisionId")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("EmployeeSurname")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("IdentificationNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Month")
                        .HasColumnType("int");

                    b.Property<int>("OfficeId")
                        .HasColumnType("int");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.Property<decimal>("ProductionBonus")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.HasIndex("OfficeId");

                    b.HasIndex("PositionId");

                    b.ToTable("Salaries");
                });

            modelBuilder.Entity("CompanyManagement.Domain.Entities.Salary", b =>
                {
                    b.HasOne("CompanyManagement.Domain.Entities.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyManagement.Domain.Entities.Office", "Office")
                        .WithMany()
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CompanyManagement.Domain.Entities.Position", "Position")
                        .WithMany()
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Division");

                    b.Navigation("Office");

                    b.Navigation("Position");
                });
#pragma warning restore 612, 618
        }
    }
}