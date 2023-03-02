using MediatR;
using RequisiteTypeService.Domain;

namespace RequisiteTypeService.Application.CQRS.Command.UpdateRequisiteType
{
    public class UpdateRequisiteTypeCommand : IRequest<RequisiteType>
    {
        public int id { get; set; }
        public int currencyId { get; set; }
        public string organisation { get; set; }
        public string description { get; set; }
        public string updatedAt { get; set; }
    }
}
