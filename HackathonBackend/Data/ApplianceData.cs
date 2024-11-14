using System.Collections.Generic;
using HackathonBackend.Models;

namespace HackathonBackend.Data
{
    public static class ApplianceData
    {
        public static List<Appliance> GetAppliances()
        { //hi
            return new List<Appliance>
            {
                new Appliance { ApplianceId = 1, Name = "Microwave", IsSchedulable = false },
                new Appliance { ApplianceId = 2, Name = "Dishwasher", IsSchedulable = true },
                new Appliance { ApplianceId = 3, Name = "Refrigerator and freezer", IsSchedulable = true },
                new Appliance { ApplianceId = 4, Name = "Oven and stove", IsSchedulable = false },
                new Appliance { ApplianceId = 5, Name = "Coffee maker", IsSchedulable = false },
                new Appliance { ApplianceId = 6, Name = "Toaster", IsSchedulable = false },
                new Appliance { ApplianceId = 7, Name = "Electric heaters or radiators", IsSchedulable = true },
                new Appliance { ApplianceId = 8, Name = "Underfloor heating", IsSchedulable = false },
                new Appliance { ApplianceId = 9, Name = "Air conditioning (AC)", IsSchedulable = true },
                new Appliance { ApplianceId = 10, Name = "Heat pump", IsSchedulable = true },
                new Appliance { ApplianceId = 11, Name = "Water heater", IsSchedulable = false },
                new Appliance { ApplianceId = 12, Name = "Towel warmers", IsSchedulable = true },
                new Appliance { ApplianceId = 13, Name = "Washing machine", IsSchedulable = true },
                new Appliance { ApplianceId = 14, Name = "Tumble dryer", IsSchedulable = true },
                new Appliance { ApplianceId = 15, Name = "Drying cabinet", IsSchedulable = true },
                new Appliance { ApplianceId = 16, Name = "TVs", IsSchedulable = true },
                new Appliance { ApplianceId = 17, Name = "Desktop computer", IsSchedulable = false },
                new Appliance { ApplianceId = 18, Name = "Laptop", IsSchedulable = false },
                new Appliance { ApplianceId = 19, Name = "Game consoles", IsSchedulable = false },
                new Appliance { ApplianceId = 20, Name = "Home theater systems", IsSchedulable = false },
                new Appliance { ApplianceId = 21, Name = "Incandescent bulbs", IsSchedulable = false },
                new Appliance { ApplianceId = 22, Name = "LED bulbs", IsSchedulable = false },
                new Appliance { ApplianceId = 23, Name = "Electric saunas", IsSchedulable = false },
                new Appliance { ApplianceId = 24, Name = "Pool heaters and pumps", IsSchedulable = false },
                new Appliance { ApplianceId = 25, Name = "Jacuzzi or hot tub", IsSchedulable = false }
            };
        }
    }
}
