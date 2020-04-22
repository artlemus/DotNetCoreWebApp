using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ERP.Models;

namespace erp.Controllers
{

    public class CatalogController : Controller
    {
        //  /catalog/index
        // /catalog
        public IActionResult Index()
        {
            return View();
        }

        // /catalog/register
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveCar([FromBody] Car car){
            System.Console.WriteLine("saving new car");
            System.Console.WriteLine(car.Make);
            // save car to DB

            car.Id = 1;
            return Json(car);

        }

        [HttpGet]
        public IActionResult GetCatalog(){
            // reads the list from DB/sends list of cars

            List<Car> cars = new List<Car>();
            var c1 = new Car();
            c1.Make = "Subaru";
            c1.Model = "Legacy";
            c1.Year = 1999;

            cars.Add(c1);

            return Json(cars);
        }

}

}