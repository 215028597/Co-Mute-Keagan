using System;
using System.ComponentModel.DataAnnotations;

namespace Co_Mute.Models
{
    public class CarPoolModel
    {
        [Required]
        public TimeSpan DepartTime { get; set; }
        [Required]
        public TimeSpan expectTime { get; set; }    

        public string Origin { get; set; }
        
        [Required]  
        public int DaysAvail { get; set; }
        [Required]
        public int AvailSeats { get; set; }
        [Required]
        public string OwnerLeader { get; set; }

        public string Notes { get; set; }
    }
}
