using MediatR;
using RequisiteTypeService.Domain;

namespace RequisiteTypeService.Application.CQRS.Command.Create
{
    public class CreateRequisiteTypeСommand : IRequest<RequisiteType>
    {
        public int id { get; set; }
        public int currencyId { get; set; }
        public string organisation { get; set; }
        public string description { get; set; }
    }
}
