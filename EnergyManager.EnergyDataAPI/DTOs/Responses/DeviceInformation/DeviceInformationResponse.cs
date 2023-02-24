using EnergyManager.EnergyDataAPI.DTOs.Responses.UnitsOfMeasurement;

namespace EnergyManager.EnergyDataAPI.DTOs.Responses.DeviceInformation
{
    public class DeviceInformationResponse
    {
        public Guid DeviceDataId { get; set; }
        public string? DeviceName { get; set; }
        public string? DeviceDescription { get; set; } 
        public bool DeviceEnabled { get; set; }                                                              
        public UnitsOfMeasurementResponse? UnitsOfMeasurement { get; set; }        
    }
}
