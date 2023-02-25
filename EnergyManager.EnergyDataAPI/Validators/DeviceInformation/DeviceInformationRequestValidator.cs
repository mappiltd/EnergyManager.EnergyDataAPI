using EnergyManager.EnergyDataAPI.DTOs.Requests.DeviceInformation;
using EnergyManager.EnergyDataAPI.DTOs.Requests.UnitsOfMeasurement;
using EnergyManager.EnergyDataAPI.Validators.Types;
using EnergyManager.EnergyDataAPI.Validators.UnitsOfMeasurement;
using FluentValidation;

namespace EnergyManager.EnergyDataAPI.Validators.DeviceInformation
{
    public class DeviceInformationRequestValidator : AbstractValidator<DeviceInformationRequest>
    {
        public DeviceInformationRequestValidator()
        {
            RuleFor(x => x.DeviceDataId).NotNull().NotEmpty().WithMessage("The device request requires an Id!");
            RuleFor(x => x.DeviceName).NotNull().NotEmpty().WithMessage("The device request requires a name!");
            RuleFor(x => x.DeviceDescription).NotNull().NotEmpty().WithMessage("The device request requires a description!");
            RuleFor(x => x.CustomerId).NotNull().NotEmpty().WithMessage("The device request requires a customer Id!");
            RuleFor(x => x.LocationId).NotNull().NotEmpty().WithMessage("The device request requires a location Id!");
            RuleFor(x => x.BuildingId).NotNull().NotEmpty().WithMessage("The device request requires a building Id!");            
            RuleFor(x => x.UnitsOfMeasurement).SetValidator(new UnitsOfMeasurementRequestValidator());     
        }
    }
}
