
namespace HackathonBackend.Data
{
    public static class DummyDataGenerator
    {
        public static EnergyProfile GenerateDummyEnergyProfile()
        {
            var appliances = ApplianceData.GetAppliances();

            // Manually select specific ApplianceIds 
            var selectedApplianceIds = new List<int> { 2, 4, 12, 13, 16, 19 };

            return new EnergyProfile
            {
                EnergyProfileId = 1,
                ApplianceIds = selectedApplianceIds,
                Date = DateTime.Now
                // Or add data point as reference
            };
        }
    }
}