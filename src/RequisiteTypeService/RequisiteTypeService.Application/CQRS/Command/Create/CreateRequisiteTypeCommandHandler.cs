using MediatR;
using RequisiteTypeService.Application.Interface;
using RequisiteTypeService.Domain;
using System.Diagnostics;

namespace RequisiteTypeService.Application.CQRS.Command.Create
{
    public class CreateRequisiteTypeCommandHandler : IRequestHandler<CreateRequisiteTypeСommand, RequisiteType>
    {
        public CreateRequisiteTypeCommandHandler(IRequisiteTypeContext context)
        {
            _requisiteTypeContext = context;
        }
        private readonly IRequisiteTypeContext _requisiteTypeContext;
        public async Task<RequisiteType> Handle(CreateRequisiteTypeСommand request, CancellationToken cancellationToken)
        {
            var content = new RequisiteType
            {
                currencyId = request.currencyId,
                organisation = request.organisation,
                description = request.description,
                createdAt = DateTime.Now.ToString(),
                updatedAt = DateTime.Now.ToString(),
            };
            await _requisiteTypeContext.requisiteType.AddRangeAsync(content);
            await _requisiteTypeContext.SaveChangesAsync(cancellationToken);
            return content;
        }
    }
}
