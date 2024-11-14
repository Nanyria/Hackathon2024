namespace HackathonBackend.Models
{
    public class DateAndEnergyUse
    {
        public int DateAndEnergyUseId { get; set; }
        public double EnergyUsage { get; set; }
        public DateTime Date { get; set; }
        public int EnergyProfileId { get; set; }
        public EnergyProfile EnergyProfile { get; set; }
        // Indicate appliance energy usage for recommendation purposes.
    }
}
