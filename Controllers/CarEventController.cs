using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using test_1_WebApplication.Models;

namespace test_1_WebApplication.Controllers
{
    public class CarEventController : Controller
    {
        private List<CarEvent> carEvents = new List<CarEvent>
        {
            new CarEvent { Id = 1, Name = "Car Show 1", Date = DateTime.Now.AddMonths(1), Location = "City 1", Description = "Description 1" },
            new CarEvent { Id = 2, Name = "Car Show 2", Date = DateTime.Now.AddMonths(2), Location = "City 2", Description = "Description 2" },
            new CarEvent { Id = 3, Name = "Car Show 3", Date = DateTime.Now.AddMonths(3), Location = "City 3", Description = "Description 3" },
            new CarEvent { Id = 4, Name = "Car Show 4", Date = DateTime.Now.AddMonths(4), Location = "City 4", Description = "Description 4" },
            new CarEvent { Id = 5, Name = "Car Show 5", Date = DateTime.Now.AddMonths(5), Location = "City 5", Description = "Description 5" },
            new CarEvent { Id = 6, Name = "Car Show 6", Date = DateTime.Now.AddMonths(6), Location = "City 6", Description = "Description 6" },
        };
        public IActionResult Index()
        {
            return View(carEvents);
        }
        public IActionResult Details(int id)
        {
            var carEvent = carEvents.Find(e => e.Id == id);
            if (carEvent == null)
            {
                return NotFound();
            }

            return View(carEvent);
        }
    }
}
