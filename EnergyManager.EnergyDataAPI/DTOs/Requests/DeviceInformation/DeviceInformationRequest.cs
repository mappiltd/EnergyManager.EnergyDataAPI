namespace EnergyManager.EnergyDataAPI.DTOs.Requests.DeviceInformation
{
    public class DeviceInformationRequest
    {
        public Guid DeviceDataId { get; set; }             
        public Guid CustomerId { get; set; }
        public Guid LocationId { get; set; }
        public Guid BuildingId { get; set; }         
    }
}
