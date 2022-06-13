using BasicVersion1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BasicVersion1.EfCore.Configuration
{
    public class DEPARTMENTConfiguration : IEntityTypeConfiguration<DEPARTMENT>
    {
        public void Configure(EntityTypeBuilder<DEPARTMENT> builder)
        {

        }
    }
}