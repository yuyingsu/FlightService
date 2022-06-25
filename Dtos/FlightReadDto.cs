namespace FlightService.Dtos
{
    public class FlightReadDto
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public String Time { get; set; }
    }

}