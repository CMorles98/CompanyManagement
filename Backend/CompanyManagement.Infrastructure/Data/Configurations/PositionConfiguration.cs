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
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.ToTable("Positions");

            builder.Property(o => o.PositionName).HasMaxLength(50).IsRequired();

            builder.HasOne(o => o.Division).WithMany(d => d.Positions).HasForeignKey(x => x.DivisionId).OnDelete(DeleteBehavior.NoAction);

            builder.HasData(DbUtils.GetPositions());
        }
    }
}
