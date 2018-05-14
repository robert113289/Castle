using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Castle.Models;
using Castle.Data;

namespace Castle.Controllers
{
    public class HomeController : Controller
    {
        private readonly CastleDbContext context;
        public HomeController(CastleDbContext dbcontext)
        {
            context = dbcontext;
        }


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
            if (ModelState.IsValid)
            {
                context.PotentialPlayers.Add(newPotentialPlayer);
                context.SaveChanges();
                ViewBag.Message = "Thanks for submitting your request, " + newPotentialPlayer.Name + ". We will be in contact with you.";
                ViewBag.PlayerName = newPotentialPlayer.Name;
            }
            else
            {
                ViewBag.Message = "Something went wrong. Please try again";
            }
                
                return View();
        }


       /* [HttpPost]
        public IActionResult Testimonial(Testimonial newSubmission)
        {
            
            Models.Testimonial.AddToMasterList(newSubmission);

            ViewBag.Message = "Thanks for submitting! Your testimonial is being reviewed by one of our admins.";
            ViewBag.Testimonials = Models.Testimonial.TestimonialMasterList.OrderByDescending(x => x.ID);
            return View();
        }
        [HttpGet]
        public IActionResult Testimonial()
        {

            ViewBag.Testimonials = Models.Testimonial.TestimonialMasterList.OrderByDescending(x => x.ID);
            return View();
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/
        


    }
}
