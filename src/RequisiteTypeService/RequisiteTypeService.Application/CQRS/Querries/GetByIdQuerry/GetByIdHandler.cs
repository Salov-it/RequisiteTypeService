using MediatR;
using Microsoft.EntityFrameworkCore;
using RequisiteTypeService.Application.Interface;
using RequisiteTypeService.Domain;


namespace RequisiteTypeService.Application.CQRS.Querries.GetByIdQuerry
{
    public class GetByIdHandler : IRequestHandler<GetByIdQuerry, RequisiteType>
    {
        private readonly IRequisiteTypeContext _tradeContext;
        public GetByIdHandler(IRequisiteTypeContext tradeContext)
        {
            _tradeContext = tradeContext;
        }
        public async Task<RequisiteType> Handle(GetByIdQuerry request, CancellationToken cancellationToken)
        {
            return await _tradeContext.requisiteType.FirstOrDefaultAsync(w => w.id == request.Id, cancellationToken);
        }
    }
}
