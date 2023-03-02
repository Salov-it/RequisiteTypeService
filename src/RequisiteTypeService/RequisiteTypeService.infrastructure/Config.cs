using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RequisiteTypeService.Domain;
using System.Diagnostics;

namespace RequisiteTypeService.infrastructure
{
    internal class Config : IEntityTypeConfiguration<RequisiteType>
    {
        public void Configure(EntityTypeBuilder<RequisiteType> builder)
        {
            builder.HasIndex(w => w.id).IsUnique();
            builder.HasKey(w => w.id);
        }
    }
}
