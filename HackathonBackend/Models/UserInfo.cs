using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HackathonBackend.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; } 
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        // List of checks, renamed to 'EnergyAssessments' for clarity
        public List<EnergyCheck> EnergyCheck { get; set; } = new List<EnergyCheck>();

        // List of EnergyProfiles associated with this user
        public List<EnergyProfile> EnergyProfiles { get; set; } = new List<EnergyProfile>();
    }
}
