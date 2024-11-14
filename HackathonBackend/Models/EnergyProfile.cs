using System.ComponentModel.DataAnnotations;

namespace HackathonBackend.Models
{
    public class EnergyProfile
    {
        [Key]
        public int EnergyProfileId { get; set; }
        public string Name { get; set; }
        public List<DateAndEnergyUse> DateAndEnergyUses { get; set; } = new List<DateAndEnergyUse>();

        public int UserInfoId { get; set; }
        public UserInfo UserInfo { get; set; }
        public List<Appliance> Appliances { get; set; } = new List<Appliance>();

    }
}
