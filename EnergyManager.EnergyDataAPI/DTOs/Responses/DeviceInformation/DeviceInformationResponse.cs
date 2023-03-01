using EnergyManager.EnergyDataAPI.DTOs.Requests.Customers;
using EnergyManager.EnergyDataAPI.DTOs.Requests.UnitsOfMeasurement;

namespace EnergyManager.EnergyDataAPI.DTOs.Responses.DeviceInformation
{
    public class DeviceInformationResponse
    {
        public Guid DeviceDataId { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceDescription { get; set; } 
        public bool DeviceEnabled { get; set; }
        public UnitsOfMeasurementRequest? UnitsOfMeasurement { get; set; }
        public BuildingsRequest? BuildingData { get; set; }
        public LocationsRequest? LocationData { get; set; }        
    }
}
