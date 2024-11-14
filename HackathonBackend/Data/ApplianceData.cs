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
                new Appliance { ApplianceId = 1, Name = "Microwave" },
                new Appliance { ApplianceId = 2, Name = "Dishwasher" },
                new Appliance { ApplianceId = 3, Name = "Refrigerator and freezer" },
                new Appliance { ApplianceId = 4, Name = "Oven and stove" },
                new Appliance { ApplianceId = 5, Name = "Coffee maker" },
                new Appliance { ApplianceId = 6, Name = "Toaster" },
                new Appliance { ApplianceId = 7, Name = "Electric heaters or radiators" },
                new Appliance { ApplianceId = 8, Name = "Underfloor heating" },
                new Appliance { ApplianceId = 9, Name = "Air conditioning (AC)" },
                new Appliance { ApplianceId = 10, Name = "Heat pump" },
                new Appliance { ApplianceId = 11, Name = "Water heater" },
                new Appliance { ApplianceId = 12, Name = "Towel warmers" },
                new Appliance { ApplianceId = 13, Name = "Washing machine" },
                new Appliance { ApplianceId = 14, Name = "Tumble dryer" },
                new Appliance { ApplianceId = 15, Name = "Drying cabinet" },
                new Appliance { ApplianceId = 16, Name = "TVs" },
                new Appliance { ApplianceId = 17, Name = "Desktop computer" },
                new Appliance { ApplianceId = 18, Name = "Laptop" },
                new Appliance { ApplianceId = 19, Name = "Game consoles" },
                new Appliance { ApplianceId = 20, Name = "Home theater systems" },
                new Appliance { ApplianceId = 21, Name = "Incandescent bulbs" },
                new Appliance { ApplianceId = 22, Name = "LED bulbs" },
                new Appliance { ApplianceId = 23, Name = "Electric saunas" },
                new Appliance { ApplianceId = 24, Name = "Pool heaters and pumps" },
                new Appliance { ApplianceId = 25, Name = "Jacuzzi or hot tub" }
            };
        }
    }
}
