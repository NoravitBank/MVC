using BasicVersion1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BasicVersion1.EfCore.Configuration
{
    public class POSITIONConfiguration : IEntityTypeConfiguration<POSITION>
    {
        public void Configure(EntityTypeBuilder<POSITION> builder)
        {

        }
    }
}