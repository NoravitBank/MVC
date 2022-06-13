using BasicVersion1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BasicVersion1.EfCore.Configuration
{
    public class EMPLOYEEConfiguration : IEntityTypeConfiguration<EMPLOYEE>
    {
        public void Configure(EntityTypeBuilder<EMPLOYEE> builder)
        {
            builder.HasOne(a => a.Position)
                .WithMany(b=>b.Employees)
                .HasForeignKey(c=>c.PositionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Department)
                .WithMany(b => b.Employees)
                .HasForeignKey(c => c.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(a => a.Company)
                .WithMany(b => b.Employees)
                .HasForeignKey(c => c.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}