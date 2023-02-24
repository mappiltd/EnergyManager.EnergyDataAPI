using EnergyManager.EnergyDataAPI.DTOs.Requests.DeviceInformation;
using FluentValidation;

namespace EnergyManager.EnergyDataAPI.Validators.DeviceInformation
{
    public class DeviceInformationRequestValidator : AbstractValidator<DeviceInformationRequest>
    {
        public DeviceInformationRequestValidator()
        {
        }
    }
}
