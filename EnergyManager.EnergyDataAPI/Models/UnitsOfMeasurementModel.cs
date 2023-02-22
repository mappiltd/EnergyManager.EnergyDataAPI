using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnergyManager.EnergyDataAPI.Models
{
    [Table("UnitsOfMeasurement")]
    public class UnitsOfMeasurementModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UnitsOfMeasurementId { get; set; }

        public int Value { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }        
    }
}
