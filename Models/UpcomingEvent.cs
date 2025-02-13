namespace MetalUniverse.Models
{
    public class UpcomingEvent
    {
        public int EventID { get; set; }
        public string? EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string? Location { get; set; }
        public string? Description { get; set; }
        public int TicketsLeft { get; set; }
        public decimal Price { get; set; }
        public string? ImagePath { get; set; }
    }
}
