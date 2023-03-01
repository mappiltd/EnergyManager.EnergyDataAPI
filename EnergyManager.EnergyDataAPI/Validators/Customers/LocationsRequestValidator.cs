using EnergyManager.EnergyDataAPI.DTOs.Requests.Customers;
using FluentValidation;

namespace EnergyManager.EnergyDataAPI.Validators.Customers
{
    public class LocationsRequestValidator  : AbstractValidator<LocationsRequest>
    {
        public LocationsRequestValidator()
        {

        }
    }
}
