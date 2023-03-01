using EnergyManager.EnergyDataAPI.Models.Customers;

namespace EnergyManager.EnergyDataAPI.DTOs.Responses.Customers
{
    public class LocationsResponse
    {        
        public Guid LocationId { get; set; }      
        public Guid LocationDescription { get; set; }
        public DateTime LocationCreated { get; set; }                  
        public Guid CustomerId { get; set; }
        public BuildingModel? Building { get; set; }
        public AddressModel? Address { get; set; }
    }
}
