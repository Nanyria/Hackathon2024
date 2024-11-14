using System.ComponentModel.DataAnnotations;

namespace HackathonBackend.Models
{
    public class Appliance
    {
        [Key]   
        public int ApplianceId { get; set; }
        public string Name { get; set; }
        public List<ApplianceEnergyUsage> energyUsages { get; set; }
        public int EnergyProfileId { get; set; }
        public EnergyProfile EnergyProfile { get; set; }
        // New Tag property to indicate high or low energy usage. For recommendation purposes.
        public string Tag { get; set; } = "High";
    }
}
