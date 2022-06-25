using System.ComponentModel.DataAnnotations;

namespace FlightService.Dtos
{
    public class FlightCreateDto
    {
        [Required]
        public int Capacity { get; set; }
        [Required]
        public string From { get; set; }
        [Required]
        public string To { get; set; }
        [Required]
        public String Time { get; set; }
    }

}