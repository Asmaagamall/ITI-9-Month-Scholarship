using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFTool_MVC.context;
using EFTool_MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

    public class ProductController : Controller
    {
    public NorthwindContext Context { get; }

    public ProductController(NorthwindContext context)
    {
        Context = context;
    }
    // GET: ProductController
    public ActionResult Index()
        {
            return View(Context.Products.ToList());
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            var prd = Context.Products.FirstOrDefault(p=>p.ProductId == id);
            return View(prd);
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            try
            {
                Context.Products.Add(product);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            var prd = Context.Products.Find(id);
            return View(prd);
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            try
            {
                Context.Products.Update(product);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            var prd = Context.Products.Find(id);
            return View(prd);
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var prd = Context.Products.Find(id);
                Context.Products.Remove(prd);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
