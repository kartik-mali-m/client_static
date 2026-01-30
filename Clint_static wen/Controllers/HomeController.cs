using System.Diagnostics;
using Clint_static_wen.Models;
using Microsoft.AspNetCore.Mvc;

namespace Clint_static_wen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Featured vehicles
            var vehicles = new List<Vehicle>
            {
                new Vehicle { Id = 1, Name = "Toyota Innova", Type = "SUV", Seats = 7, PricePerKm = 15, PricePerHour = 300, ImageUrl = "/images/vehicles/innova.jpg", Description = "Comfortable family car with AC", IsAvailable = true },
                new Vehicle { Id = 2, Name = "Swift Dzire", Type = "Sedan", Seats = 4, PricePerKm = 12, PricePerHour = 250, ImageUrl = "/images/vehicles/swift.jpg", Description = "Economical sedan for city rides", IsAvailable = true },
                new Vehicle { Id = 3, Name = "Tempo Traveller", Type = "Van", Seats = 12, PricePerKm = 25, PricePerHour = 500, ImageUrl = "/images/vehicles/tempo.jpg", Description = "Perfect for group travels", IsAvailable = true },
                new Vehicle { Id = 4, Name = "Mercedes E-Class", Type = "Luxury", Seats = 4, PricePerKm = 35, PricePerHour = 800, ImageUrl = "/images/vehicles/mercedes.jpg", Description = "Premium luxury experience", IsAvailable = true }
            };

            // Services
            var services = new List<Service>
            {
                new Service { Id = 1, Title = "Airport Transfer", Description = "24/7 airport pickup and drop service", IconClass = "fas fa-plane", ImageUrl = "/images/services/airport.jpg" },
                new Service { Id = 2, Title = "Local City Rides", Description = "Hourly and daily rental packages", IconClass = "fas fa-city", ImageUrl = "/images/services/city.jpg" },
                new Service { Id = 3, Title = "Outstation Trips", Description = "Long distance travel with experienced drivers", IconClass = "fas fa-road", ImageUrl = "/images/services/outstation.jpg" },
                new Service { Id = 4, Title = "Wedding & Events", Description = "Special vehicles for weddings and events", IconClass = "fas fa-ring", ImageUrl = "/images/services/wedding.jpg" }
            };

            ViewBag.Vehicles = vehicles;
            ViewBag.Services = services;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Title"] = "About Us";
            ViewData["Message"] = "Your trusted travel partner since 2010";
            return View();
        }

        public IActionResult Services()
        {
            var allServices = new List<Service>
            {
                new Service { Id = 1, Title = "Local Taxi Service", Description = "Available for local rides with professional drivers" },
                new Service { Id = 2, Title = "One Way Taxi Service", Description = "Perfect for one-way trips with fixed pricing" },
                new Service { Id = 3, Title = "26 Seater Tempo Traveller", Description = "Ideal for large group travels" },
                new Service { Id = 4, Title = "20 Seater Tempo Traveller", Description = "Comfortable for medium-sized groups" },
                new Service { Id = 5, Title = "17 Seater Tempo Traveller", Description = "Balanced size for family tours" },
                new Service { Id = 6, Title = "13 Seater Tempo Traveller", Description = "Compact group travel solution" },
                new Service { Id = 7, Title = "Tata Winger 15 Seater", Description = "Spacious and comfortable" },
                new Service { Id = 8, Title = "Tata Winger 12 Seater", Description = "Perfect for corporate travel" },
                new Service { Id = 9, Title = "Tata Winger 10 Seater", Description = "Economical group travel option" }
            };

            return View(allServices);
        }

        public IActionResult Fleet()
        {
            var fleet = new List<Vehicle>
            {
                new Vehicle { Id = 1, Name = "Toyota Innova Crysta", Type = "SUV", Seats = 7, ImageUrl = "/images/fleet/innova-crysta.jpg" },
                new Vehicle { Id = 2, Name = "Kia Carens", Type = "MPV", Seats = 6, ImageUrl = "/images/fleet/carens.jpg" },
                new Vehicle { Id = 3, Name = "Hyundai Creta", Type = "SUV", Seats = 5, ImageUrl = "/images/fleet/creta.jpg" },
                new Vehicle { Id = 4, Name = "Swift Dzire", Type = "Sedan", Seats = 4, ImageUrl = "/images/fleet/dzire.jpg" },
                new Vehicle { Id = 5, Name = "Tempo Traveller 26S", Type = "Van", Seats = 26, ImageUrl = "/images/fleet/tempo-26.jpg" },
                new Vehicle { Id = 6, Name = "Mercedes E-Class", Type = "Luxury", Seats = 4, ImageUrl = "/images/fleet/e-class.jpg" }
            };

            return View(fleet);
        }

        public IActionResult Pricing()
        {
            var pricing = new
            {
                Local = new[]
                {
                    new { Vehicle = "Suit/Cab", Single = "?1000", Double = "?1500", Business = "?12/hr" },
                    new { Vehicle = "Monorail", Single = "?2500", Double = "?3500", Business = "?20/hr" },
                    new { Vehicle = "Kia Carens", Single = "?3000", Double = "?4000", Business = "?25/hr" },
                    new { Vehicle = "Toyota Innova", Single = "?2000", Double = "?2800", Business = "?30/hr" }
                },
                Airport = new[]
                {
                    new { Vehicle = "Suit/Cab", Single = "?500", Double = "?750", Business = "?12/hr" },
                    new { Vehicle = "Monorail", Single = "?1000", Double = "?1500", Business = "?20/hr" },
                    new { Vehicle = "Kia Carens", Single = "?1500", Double = "?2200", Business = "?25/hr" }
                }
            };

            return View(pricing);
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult BookNow()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BookNow(Booking booking)
        {
            if (ModelState.IsValid)
            {
                // Here you would save to database
                TempData["SuccessMessage"] = "Booking confirmed! We'll contact you shortly.";
                return RedirectToAction("Index");
            }
            return View(booking);
        }

        public IActionResult Owner()
        {
            var ownerInfo = new
            {
                Name = "Javeriya Tour's",
                Location = "Lohgaon, Pune",
                Services = "Airport Pickup & Drop Service",
                Phone = "9657323988",
                Features = new[] { "Neat & Clean Cars", "On Time Service", "24/7 Available" }
            };

            return View(ownerInfo);
        }

        public IActionResult Emergency()
        {
            return View();
        }
    }
}
