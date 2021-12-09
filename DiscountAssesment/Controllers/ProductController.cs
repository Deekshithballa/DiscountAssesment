using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiscountAssesment.Models;

namespace DiscountAssesment.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Calculation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calculation(ClearanceSale cs)
        {
            string name = cs.ProductName;
            ViewBag.info1 = name;
            double p = double.Parse(cs.price);
            string sale = cs.isSale;
            int day1 = int.Parse(cs.day1sale);
            int day2 = int.Parse(cs.day2sale);
            int day3 = int.Parse(cs.day3sale);
            double d1, d2, d3;
           
                d1 = p - (p * 0.07);
                d2 = d1 - (d1 * 0.07);
                d3 = d2 - (d2 * 0.07);
                ViewBag.info2 = "Day 1 Sales Total : " + d1 * day1; 
                ViewBag.info3 = "Day 2 Sales Total : " + d2 * day2;
                ViewBag.info4 = "Day 3 Sales Total : " + d3 * day3;

            return View();


        }
        
    }
}