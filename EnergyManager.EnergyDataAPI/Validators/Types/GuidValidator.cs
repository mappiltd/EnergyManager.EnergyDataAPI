using FluentValidation;

namespace EnergyManager.EnergyDataAPI.Validators.Types
{
    public class GuidValidator : AbstractValidator<Guid>
    {
        public GuidValidator()
        {
            RuleFor(g => g).NotEmpty().WithMessage("Guid must not be empty");
        }
    }
}
