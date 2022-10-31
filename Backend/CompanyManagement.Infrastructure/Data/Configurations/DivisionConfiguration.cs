using CompanyManagement.Domain.Entities;
using CompanyManagement.Infrastructure.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Infrastructure.Data.Configurations
{
    public class DivisionConfiguration : IEntityTypeConfiguration<Division>
    {
        public void Configure(EntityTypeBuilder<Division> builder)
        {
            builder.ToTable("Divisions");

            builder.Property(o => o.DivisionName).HasMaxLength(50).IsRequired();

            builder.HasData(DbUtils.GetDivisions());
        }
    }
}
