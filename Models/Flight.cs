using System.ComponentModel.DataAnnotations;

namespace FlightService.Models
{ 
    public class Flight
    {

        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public string From { get; set; }
        [Required]
        public string To { get; set; }
        public DateTime Time { get; set; }
    }
}