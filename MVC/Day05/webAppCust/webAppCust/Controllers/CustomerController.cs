using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webAppCust.Models;

namespace webAppCust.Controllers
{
    [RoutePrefix("Cust")]
    public class CustomerController : Controller
    {
        // GET: Customer
        [Route("")]
        public ActionResult Index()
        {
            return View(CustomerList.customers);
        }
       

        // GET: Customer/Details/5
        [Route("Details/{id:int:min(1)}")]
        public ActionResult Details(int id)
        {
            return View(CustomerList.customers.Where(p=>p.Id == id).FirstOrDefault());
        }

        // GET: Customer/Create
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [Route("Create")]

        [HttpPost]
        public ActionResult Create(Customer cust)
        {
            if (ModelState.IsValid)
            {
                CustomerList.customers.Add(cust);
                return RedirectToAction("Index");
            }


            return View();
        }

        // GET: Customer/Edit/5
        [Route("Edit/{id:int:min(2)}")]

        public ActionResult Edit(int id)
        {
            var selectedcust = CustomerList.customers.Find(p=>p.Id == id);
            return View(selectedcust);
        }

        // POST: Customer/Edit/5
        [Route("Edit/{id:int:min(2)}")]

        [HttpPost]
        public ActionResult Edit(int id,Customer cust)
        {
            try
            {

                Customer customer = CustomerList.customers.Where(e => e.Id == id).FirstOrDefault();

                customer.Name = cust.Name;
                customer.Email = cust.Email;
                customer.Gender = cust.Gender;
                customer.Phone = cust.Phone;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        [Route("~/Customer/Delete/{id}")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var selectedcust = CustomerList.customers.Find(p=>p.Id == id);
                CustomerList.customers.Remove(selectedcust);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
