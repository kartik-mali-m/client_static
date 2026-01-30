namespace Clint_static_wen.Models
{
    public class Vehicle
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Seats { get; set; }
        public decimal PricePerKm { get; set; }
        public decimal PricePerHour { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }
    }
}
