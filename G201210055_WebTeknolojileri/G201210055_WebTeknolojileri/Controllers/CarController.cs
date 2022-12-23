using G201210055_WebTeknolojileri.Models;
using Microsoft.AspNetCore.Mvc;

namespace G201210055_WebTeknolojileri.Controllers
{
    public class CarController : Controller
    {
        CarContext cr = new CarContext();
        public IActionResult AddCar()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Car c)
        {

            if (ModelState.IsValid)
            {
                cr.Add(c);
                cr.SaveChanges();
                return List();
            }
            return View();
        }
        public IActionResult List()
        {
            var cars = cr.Cars;
            return View(cars);
        }
    }
}
