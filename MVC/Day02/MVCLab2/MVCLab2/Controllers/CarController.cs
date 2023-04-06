﻿using MVCLab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public ActionResult GetCarByNum(int num) 
        { 
            ViewBag.SelectedCar = CarList.Cars.FirstOrDefault(e=>e.Num == num);
            return View();
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(int num, string Color, string Manfacture, string Model)
        {
            Car NewCar = new Car();
            NewCar.Num = num;
            NewCar.Color = Color;
            NewCar.Model = Model;
            NewCar.Manfacture = Manfacture;
            CarList.Cars.Add(NewCar);
            return RedirectToAction("GetAll");
        }
        public ActionResult Edit(int num)
        {
            ViewBag.SelectedCar = CarList.Cars.FirstOrDefault(e => e.Num == num);
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int num , string Color , string Manfacture , string Model)
        {
            Car car = CarList.Cars.FirstOrDefault(e => e.Num == num);
            car.Color = Color;
            car.Manfacture = Manfacture;
            car.Model = Model;
            return RedirectToAction("GetAll");
        }
        public ActionResult DeleteCar(int num)
        {
            var deleteCar = CarList.Cars.FirstOrDefault(e => e.Num == num);
            CarList.Cars.Remove(deleteCar);
            return RedirectToAction("GetAll");
        }
    }
}