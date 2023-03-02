using Microsoft.EntityFrameworkCore;
using RequisiteTypeService.Domain;


namespace RequisiteTypeService.Application.Interface
{
    public interface IRequisiteTypeContext
    {
        
            public DbSet<RequisiteType> requisiteType { get; set; }
            Task<int> SaveChangesAsync(CancellationToken token);
        
    }
}
