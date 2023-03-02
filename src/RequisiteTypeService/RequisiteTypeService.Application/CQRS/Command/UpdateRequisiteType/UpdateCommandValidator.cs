using FluentValidation;

namespace RequisiteTypeService.Application.CQRS.Command.UpdateRequisiteType
{
    public class UpdateCommandValidator : AbstractValidator<UpdateRequisiteTypeCommand>
    {
        public UpdateCommandValidator()
        {
            RuleFor(opt => opt.id).NotEmpty();
            RuleFor(opt => opt.id).GreaterThan(0);
            RuleFor(opr => opr.currencyId).GreaterThan(0);
        }
    }
}
