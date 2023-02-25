using EnergyManager.EnergyDataAPI.DTOs.Requests.Customers;
using EnergyManager.EnergyDataAPI.DTOs.Requests.UnitsOfMeasurement;

namespace EnergyManager.EnergyDataAPI.DTOs.Requests.DeviceInformation
{
    public class DeviceInformationRequest
    {
        public Guid DeviceDataId { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceDescription { get; set; }        
        public Guid CustomerId { get; set; }
        public Guid LocationId { get; set; }
        public Guid BuildingId { get; set; }
        public bool DeviceEnabled { get; set; }
        public DateTime DeviceDateCreated { get; set; }        
    }
}
