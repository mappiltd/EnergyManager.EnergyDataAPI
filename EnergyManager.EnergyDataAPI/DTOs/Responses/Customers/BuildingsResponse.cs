using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EnergyManager.EnergyDataAPI.Models.Customers;

namespace EnergyManager.EnergyDataAPI.DTOs.Responses.Customers
{
    public class BuildingsResponse
    {         
        public Guid BuildingId { get; set; }
        public Guid BuildingDescription { get; set; }
        public DateTime BuildingCreated { get; set; }
        public Guid CustomerId { get; set; }
        public AddressModel? Address { get; set; }
    }
}
