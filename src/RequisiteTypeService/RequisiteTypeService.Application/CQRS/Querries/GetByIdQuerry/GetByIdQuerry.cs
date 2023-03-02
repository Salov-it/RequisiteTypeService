using MediatR;
using RequisiteTypeService.Domain;

namespace RequisiteTypeService.Application.CQRS.Querries.GetByIdQuerry
{
    public class GetByIdQuerry : IRequest<RequisiteType>
    {
        public int Id { get; set; }
    }
}
