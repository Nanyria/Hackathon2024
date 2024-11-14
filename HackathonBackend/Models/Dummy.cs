
namespace HackathonBackend.Models
{
    public static class DummyData
    {
        public static List<EnergyProfile> DummyEnergyProfiles()
        {
            // Fetch the list of appliances
            var appliances = ApplianceData.GetAppliances();

            // List of different EnergyProfiles, each with manually selected ApplianceIds
            var energyProfiles = new List<EnergyProfile>
            {
                new EnergyProfile
                {
                    EnergyProfileId = 1,
                    ApplianceIds = new List<int> { 2, 4, 12, 13, 16, 19 }, // Profile with specific appliances 
                    Date = DateTime.Now
                    // Or add data point as reference
                },
                new EnergyProfile
                {
                    EnergyProfileId = 2,
                    ApplianceIds = new List<int> { 1, 3, 5, 9, 15 }, // Different set of appliances
                    Date = DateTime.Now
                    // Or add data point as reference
                },
                new EnergyProfile
                {
                    EnergyProfileId = 3,
                    ApplianceIds = new List<int> { 7, 8, 10, 14, 17 },
                    Date = DateTime.Now
                    // Or add data point as reference
                },
                new EnergyProfile
                {
                    EnergyProfileId = 4,
                    ApplianceIds = new List<int> { 6, 11, 18, 20, 25 },
                    Date = DateTime.Now
                    // Or add data point as reference
                },
                new EnergyProfile
                {
                    EnergyProfileId = 5,
                    ApplianceIds = new List<int> { 22, 23, 24 },
                    Date = DateTime.Now
                    // Or add data point as reference
                }
            };

            return energyProfiles;
        }
    }
}
