using MediatR;
using Microsoft.EntityFrameworkCore;
using RequisiteTypeService.Application.Interface;
using RequisiteTypeService.Domain;


namespace RequisiteTypeService.Application.CQRS.Querries.Get
{
    public class GetByQuerryHandler : IRequestHandler<GetByQuerry, List<RequisiteType>>
    {
        private readonly IRequisiteTypeContext _context;
        public GetByQuerryHandler(IRequisiteTypeContext context)
        {
            _context = context;
        }

        public async Task<List<RequisiteType>> Handle(GetByQuerry request, CancellationToken cancellationToken)
        {
            return await _context.requisiteType.ToListAsync(cancellationToken);
        }
    }
}
