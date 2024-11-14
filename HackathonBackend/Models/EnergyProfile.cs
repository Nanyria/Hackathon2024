using System.ComponentModel.DataAnnotations;

namespace HackathonBackend.Models
{
    public class EnergyProfile
    {
        [Key]
        public int EnergyProfileId { get; set; }
        public List<Appliance> Appliances { get; set; }
        public DateTime Date { get; set; }

    }
}
