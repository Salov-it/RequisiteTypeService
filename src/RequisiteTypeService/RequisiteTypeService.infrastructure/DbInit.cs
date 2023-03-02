
namespace RequisiteTypeService.infrastructure
{
    public class DbInit
    {
        public static void init(RequisiteTypeContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
