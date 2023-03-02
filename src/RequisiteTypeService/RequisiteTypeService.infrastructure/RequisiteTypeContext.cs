using Microsoft.EntityFrameworkCore;
using RequisiteTypeService.Domain;
using RequisiteTypeService.Application.Interface;

namespace RequisiteTypeService.infrastructure
{
    public class RequisiteTypeContext : DbContext, IRequisiteTypeContext
    {
            public DbSet<RequisiteType> requisiteType { get; set; }

            public RequisiteTypeContext(DbContextOptions<RequisiteTypeContext> options) : base(options) { }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.ApplyConfiguration(new Config());
                base.OnModelCreating(modelBuilder);
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=RequisiteTypeBasse.db");
            }
        
    }
}
