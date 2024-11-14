namespace HackathonBackend.Models
{
    public class EnergyCheck
    {
        public int Id { get; set; }
        public int ResourceId { get; set; } // This will be the foreign key to UserId
        public DateTime AtDateTime { get; set; }
        public double ActiveEnergyOutlet { get; set; }
        public double ActiveEffectOutlet { get; set; }
        public double ActiveEnergyInput { get; set; }
        public double ActiveEffectInput { get; set; }
        public double PhaseCurrent1 { get; set; }
        public double PhaseCurrent2 { get; set; }
        public double PhaseCurrent3 { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}

//public EnergyData(int id, int resourceId, DateTime atDateTime, double activeEnergyOutlet, double activeEffectOutlet,
//                          double activeEnergyInput, double activeEffectInput, double phaseCurrent1,
//                          double phaseCurrent2, double phaseCurrent3)
//        {
//            Id = id;
//            ResourceId = resourceId;
//            AtDateTime = atDateTime;
//            ActiveEnergyOutlet = activeEnergyOutlet;
//            ActiveEffectOutlet = activeEffectOutlet;
//            ActiveEnergyInput = activeEnergyInput;
//            ActiveEffectInput = activeEffectInput;
//            PhaseCurrent1 = phaseCurrent1;
//            PhaseCurrent2 = phaseCurrent2;
//            PhaseCurrent3 = phaseCurrent3;
//        }
//    }
