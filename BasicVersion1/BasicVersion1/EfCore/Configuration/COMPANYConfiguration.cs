using BasicVersion1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BasicVersion1.EfCore.Configuration
{
    public class COMPANYConfiguration : IEntityTypeConfiguration<COMPANY>
    {
        public void Configure(EntityTypeBuilder<COMPANY> builder)
        {

        }
    }
}