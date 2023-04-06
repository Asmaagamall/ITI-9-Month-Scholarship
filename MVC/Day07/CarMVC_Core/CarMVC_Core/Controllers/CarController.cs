using Microsoft.AspNetCore.Mvc;
using MVCLab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCLab2.Controllers
{
    public class CarController : Controller
    {
        // GET: Car

        public ActionResult GetAll() 
        {
            List<Car> Carlst = CarList.Cars;
            ViewBag.Cars = Carlst;
            return View();
        }

        public ActionResult GetCarByNum(int Num) 
        { 
            ViewBag.SelectedCar = CarList.Cars.FirstOrDefault(e=>e.Num == Num);
            return View();
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(int Num, string Color, string Manfacture, string Model)
        {
            Car NewCar = new Car();
            NewCar.Num = Num;
            NewCar.Color = Color;
            NewCar.Model = Model;
            NewCar.Manfacture = Manfacture;
            CarList.Cars.Add(NewCar);
            return RedirectToAction("GetAll");
        }
        public ActionResult Edit(int Num)
        {
            ViewBag.SelectedCar = CarList.Cars.FirstOrDefault(e => e.Num == Num);
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int Num, string Color , string Manfacture , string Model)
        {
            Car car = CarList.Cars.FirstOrDefault(e => e.Num == Num);
            car.Color = Color;
            car.Manfacture = Manfacture;
            car.Model = Model;
            return RedirectToAction("GetAll");
        }
        public ActionResult DeleteCar(int Num)
        {
            var deleteCar = CarList.Cars.FirstOrDefault(e => e.Num == Num);
            CarList.Cars.Remove(deleteCar);
            return RedirectToAction("GetAll");
        }
    }
}