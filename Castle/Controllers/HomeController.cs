using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Castle.Models;

namespace Castle.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            

            return View();
        }

        public IActionResult Contact()
        {
           

            return View();
        }
        [HttpPost]
        public IActionResult Testimonial(string submission)
        {
            Models.Testimonial newpost = new Models.Testimonial(submission);
            Models.Testimonial.AddToMasterList(newpost);


            ViewBag["Testimonial"] = Models.Testimonial.TestimonialMasterList;
            return View();
        }
        [HttpGet]
        public IActionResult Tesimonial()
        {

            ViewBag["Testimonial"] = Models.Testimonial.TestimonialMasterList;
            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
