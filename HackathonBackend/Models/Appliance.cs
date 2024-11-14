using System.ComponentModel.DataAnnotations;

namespace HackathonBackend.Models
{
    public class Appliance
    {
        [Key]   
        public int ApplianceId { get; set; }
        public string Name { get; set; }
        public List <EnergyProfile> EnergyProfiles { get; set; } = new List<EnergyProfile>();
    }
}
