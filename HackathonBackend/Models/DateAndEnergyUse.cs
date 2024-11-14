namespace HackathonBackend.Models
{
    public class ApplianceEnergyUsage
    {
        public int ApplianceEnergyUsageId { get; set; }
        public double EnergyUsage { get; set; }
        public int ApplianceId { get; set; }
        public Appliance? Appliance { get; set; }
        // Indicate appliance energy usage for recommendation purposes.
        public bool IsHighEnergy { get; set; } = false;

    }
}
