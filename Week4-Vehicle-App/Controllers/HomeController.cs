using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week4_Vehicle_App.Models;

namespace Week4_Vehicle_App.Controllers
{
    public class HomeController : Controller
    {

        List<Vehicle> listModel = new List<Vehicle> 
            {
                new Car(2015, "Ford", "Mustang GT", 435, 400, 8, 44989, 1),
                new Car(2014, "Chevy", "Camaro ZL1", 580, 556, 8, 62955, 2),
                new Car(2012, "Nissan", "GTR", 530, 448, 6, 99904, 3),
                new Car(2014, "Audi", "R8", 550, 398, 10, 113190, 4),
                new Motorcycle(2013, "Ducati", "Diavel Strada", 162, 128, 2, 17995, 5),
                new Motorcycle(2013, "Ducati", "Diavel Strada", 162, 128, 2, 16748, 6),
                new Truck(2015, "GMC", "Sierra Denali", 355, 383, 8, 55500, 7)
            };

        public ActionResult Index()
        {

            return View(listModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Details(int id = -1)
        {
            if (id == -1) return RedirectToAction("Index");
            {
                Vehicle model = listModel.Where(x => x.ID == id).FirstOrDefault();    
                
                return View(model);
            }
        }

        public ActionResult ShowCars()
        {
            List<Car> model = new List<Car>();
            foreach (Vehicle vehicle in listModel)
            {
                if (vehicle.VehicleType == VehicleType.Car)
                {
                    model.Add((Car)vehicle);
                }
            }
            return View(model);
        }

        public ActionResult ShowMotorcycles()
        {
            List<Motorcycle> model = new List<Motorcycle>();
            foreach (Vehicle vehicle in listModel)
            {
                if (vehicle.VehicleType == VehicleType.Motorcycle)
                {
                    model.Add((Motorcycle)vehicle);
                }
            }
            return View(model);
        }

        public ActionResult ShowTrucks()
        {
            List<Truck> model = new List<Truck>();
            {
                foreach (Vehicle vehicle in listModel)
                {
                    if (vehicle.VehicleType == VehicleType.Truck)
                    {
                        model.Add((Truck)vehicle);
                    }
                }
            }
            return View(model);
        }
    }
}