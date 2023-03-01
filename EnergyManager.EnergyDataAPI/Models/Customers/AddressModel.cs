using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyManager.EnergyDataAPI.Models.Customers
{
    [Table("Addresses")]
    public class AddressModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid AddressId { get; set; }

        [Required]
        public string AddressName { get; set; } = string.Empty;

        [Required]
        public string AddressLine1 { get; set; } = string.Empty;

        [Required]
        public string AddressLine2 { get; set; } = string.Empty;

        [Required]
        public string AddressTownCity { get; set; } = string.Empty;

        [Required]
        public string AddressCounty { get; set; } = string.Empty;

        [Required]
        public string AddressPostCode { get; set; } = string.Empty; 
    }
}
