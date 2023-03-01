namespace EnergyManager.EnergyDataAPI.DTOs.Responses.Customers
{
    public class AddressesResponse
    {               
        public Guid AddressId { get; set; }       
        public string AddressName { get; set; } = string.Empty;        
        public string AddressLine1 { get; set; } = string.Empty;       
        public string AddressLine2 { get; set; } = string.Empty;       
        public string AddressTownCity { get; set; } = string.Empty;         
        public string AddressCounty { get; set; } = string.Empty;        
        public string AddressPostCode { get; set; } = string.Empty;
        public string AddressCountry { get; set; } = string.Empty;
    }
}
