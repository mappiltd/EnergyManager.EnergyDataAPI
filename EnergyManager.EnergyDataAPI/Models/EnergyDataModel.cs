using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EnergyManager.EnergyDataAPI.Models
{
    [Table("EnergyData")]
    public class EnergyDataModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid EnergyDataId { get; set; }

        [Required] 
        public Guid DeviceDataId { get;set; }

        [Required]
        public DateTime ReadingDate { get; set; }

        [Required]
        public TimeSpan ReadingTime 
        {
            get { return ReadingDate.TimeOfDay; }
            set { }
        }

        [Required]
        public double ReadingValue { get; set; }
    }
}
