using EnergyManager.EnergyDataAPI.DTOs.Requests.TagData;
using FluentValidation;

namespace EnergyManager.EnergyDataAPI.Validators.TagData
{
    public class TagDataRequestValidator : AbstractValidator<TagDataRequest>
    {
        public TagDataRequestValidator()
        {

        }
    }
}
