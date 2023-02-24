using EnergyManager.EnergyDataAPI.DTOs.Requests.EnergyData;
using FluentValidation;

namespace EnergyManager.EnergyDataAPI.Validators.EnergyData
{
    public class EnergyDataRequestValidator : AbstractValidator<EnergyDataRequest>
    {
        public EnergyDataRequestValidator()
        {

        }
    }
}
