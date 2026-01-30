namespace Clint_static_wen.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime PickupDate { get; set; }
        public string PickupLocation { get; set; }
        public string Destination { get; set; }
        public int VehicleId { get; set; }
        public string VehicleType { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }
    }
}
