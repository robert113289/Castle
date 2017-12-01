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
        public IActionResult Contact(PotentialPlayer newPotentialPlayer)
        {
            Models.PotentialPlayer.Add(newPotentialPlayer);
            ViewBag.Message = "Thanks for submitting your request," + newPotentialPlayer.Name +". We will be in contact with you.";
            ViewBag.PlayerName = newPotentialPlayer.Name;
            return View();
        }
        [HttpPost]
        public IActionResult Testimonial(Testimonial newSubmission)
        {
            
            Models.Testimonial.AddToMasterList(newSubmission);


            ViewBag.Testimonials = Models.Testimonial.TestimonialMasterList;
            return View();
        }
        [HttpGet]
        public IActionResult Testimonial()
        {

            ViewBag.Testimonials = Models.Testimonial.TestimonialMasterList;
            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
