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
                new Appliance { ApplianceId = 1, Name = "Microwave", Tag = "Low" },
                new Appliance { ApplianceId = 2, Name = "Dishwasher", Tag = "High" },
                new Appliance { ApplianceId = 3, Name = "Refrigerator and freezer", Tag = "High" },
                new Appliance { ApplianceId = 4, Name = "Oven and stove", Tag = "Low" },
                new Appliance { ApplianceId = 5, Name = "Coffee maker", Tag = "Low" },
                new Appliance { ApplianceId = 6, Name = "Toaster", Tag = "Low" },
                new Appliance { ApplianceId = 7, Name = "Electric heaters or radiators", Tag = "High" },
                new Appliance { ApplianceId = 8, Name = "Underfloor heating", Tag = "Low" },
                new Appliance { ApplianceId = 9, Name = "Air conditioning (AC)", Tag = "High" },
                new Appliance { ApplianceId = 10, Name = "Heat pump", Tag = "High" },
                new Appliance { ApplianceId = 11, Name = "Water heater", Tag = "Low" },
                new Appliance { ApplianceId = 12, Name = "Towel warmers", Tag = "High" },
                new Appliance { ApplianceId = 13, Name = "Washing machine", Tag = "High" },
                new Appliance { ApplianceId = 14, Name = "Tumble dryer", Tag = "High" },
                new Appliance { ApplianceId = 15, Name = "Drying cabinet", Tag = "High" },
                new Appliance { ApplianceId = 16, Name = "TVs", Tag = "High" },
                new Appliance { ApplianceId = 17, Name = "Desktop computer", Tag = "Low" },
                new Appliance { ApplianceId = 18, Name = "Laptop", Tag = "Low" },
                new Appliance { ApplianceId = 19, Name = "Game consoles", Tag = "Low" },
                new Appliance { ApplianceId = 20, Name = "Home theater systems", Tag = "Low" },
                new Appliance { ApplianceId = 21, Name = "Incandescent bulbs", Tag = "Low" },
                new Appliance { ApplianceId = 22, Name = "LED bulbs", Tag = "Low" },
                new Appliance { ApplianceId = 23, Name = "Electric saunas", Tag = "Low" },
                new Appliance { ApplianceId = 24, Name = "Pool heaters and pumps", Tag = "Low" },
                new Appliance { ApplianceId = 25, Name = "Jacuzzi or hot tub", Tag = "Low" }
            };
        }
    }
}
