using MediatR;
using RequisiteTypeService.Application.Interface;
using RequisiteTypeService.Domain;


namespace RequisiteTypeService.Application.CQRS.Command.UpdateRequisiteType
{
    public class UpdateRequisiteTypeHandler : IRequestHandler<UpdateRequisiteTypeCommand, RequisiteType>
    {
        private readonly IRequisiteTypeContext _context;
        public UpdateRequisiteTypeHandler(IRequisiteTypeContext context)
        {
            _context = context;
        }
        public async Task<RequisiteType> Handle(UpdateRequisiteTypeCommand request, CancellationToken cancellationToken)
        {
            var content = _context.requisiteType.Find(request.id);

            if (content == null)
            {
                // Exception
                return null;
            }
            
            content.currencyId = request.currencyId;
            content.organisation = request.organisation;
            content.description = request.description;
            content.updatedAt = DateTime.Now.ToString();
            
            await _context.SaveChangesAsync(cancellationToken);
           
            return content;
        }
    }
}
