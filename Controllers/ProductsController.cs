using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnetodev.Models;

namespace dotnetodev.Controllers
{
    public class ProductsController : Controller
    {
         private readonly ProductsContext veritabanim;

        public ProductsController(ProductsContext context) {
            this.veritabanim = context;
        }
        public IActionResult Index()
        {
            var urunler = veritabanim.EntityNames.ToList();
            return View(urunler);
        }
          public IActionResult Giris()
        {
            return View();
        }
       [HttpGet]
        public IActionResult Add()
        {
              veritabanim.SaveChanges();
            return View();
        }
        [HttpPost]
        public IActionResult Add(Products urun)
        {
            veritabanim.EntityNames.Add(urun);
            veritabanim.SaveChanges();
            return RedirectToAction("Index");
        }
    
        public IActionResult Remove(int Id)
        {
           var gelen = veritabanim.EntityNames.Find(Id);
           veritabanim.EntityNames.Remove(gelen);
           veritabanim.SaveChanges();
            return RedirectToAction("Index");
        }
           [HttpGet]
        public IActionResult Update(int id)
        {
            var gelenUrun=veritabanim.EntityNames.Find(id);
            return View(gelenUrun);
        }
         [HttpPost]
         public IActionResult Update(Products urun)
        {
            veritabanim.EntityNames.Update(urun);
            veritabanim.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}