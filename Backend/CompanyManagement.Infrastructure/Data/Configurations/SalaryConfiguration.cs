using CompanyManagement.Domain.Entities;
using CompanyManagement.Infrastructure.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Infrastructure.Data.Configurations
{
    public class SalaryConfiguration : IEntityTypeConfiguration<Salary>
    {
        public void Configure(EntityTypeBuilder<Salary> builder)
        {
            builder.ToTable("Salaries");

            builder.Property(o => o.EmployeeCode).HasMaxLength(10).IsRequired();
            builder.Property(o => o.EmployeeName).HasMaxLength(150).IsRequired();
            builder.Property(o => o.EmployeeSurname).HasMaxLength(150).IsRequired();
            builder.Property(o => o.IdentificationNumber).HasMaxLength(10).IsRequired();

            builder.HasData(DbUtils.GetSalaries());
        }
    }
}
