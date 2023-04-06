using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webAppCust.Models;

namespace webAppCust.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            ViewBag.order = CustomerList.customers.ToList();
            return View(OrderList.orders.ToList());
        }
        [OrderExceptionHandler]
        [HttpPost]
        public ActionResult Index(int ID)
        {
            var orders = OrderList.orders.Where(e => e.CustId == ID).ToList();
            ViewBag.order = CustomerList.customers.ToList();
            if (orders.Count == 0) throw new Exception();
            return View(orders);
        }

        // GET: Order/Details/5
        public ActionResult Details(int id)
        {
            return View(OrderList.orders.Where(p => p.Id == id).FirstOrDefault());
        }

        // GET: Order/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                OrderList.orders.Add(order);
                return RedirectToAction("Index");
            }
            return View();
            
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            var selectedOrd = OrderList.orders.Find(p => p.Id == id);
            return View(selectedOrd);
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id,Order order)
        {
            try
            {
                Order ord = OrderList.orders.FirstOrDefault(e => e.Id == id);

                ord.date= order.date;
                ord.TotalPrice = order.TotalPrice;
                ord.CustId = order.CustId;
               
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var selectedord = OrderList.orders.Find(p => p.Id == id);
                OrderList.orders.Remove(selectedord);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
