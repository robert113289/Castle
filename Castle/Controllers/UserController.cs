using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Castle.Models;
using Microsoft.AspNetCore.Authorization;
using Castle.Data;

namespace Castle.Controllers
{
    public class UserController : Controller
    {
        private readonly CastleDbContext context;
        public UserController(CastleDbContext dbcontext)
        {
            context = dbcontext;
        }

        //[Authorize]
        public ActionResult Index()
        {
            //if (id != 0)
            //{
            //    User currentUser = UserData.GetbyId(id);
            //    ViewBag.userName = currentUser.Username;
            //}
            ViewBag.PotentialPlayers = context.PotentialPlayers.ToList();
            ViewBag.Testimonials = null;
            //ViewBag.Testimonials = Models.Testimonial.TestimonialMasterList.OrderByDescending(x => x.ID);
            return View();
        }
        //public IActionResult TestimonialManagement(int id)
        //{
          
        //    Testimonial testimonial = Testimonial.GetById(id);
        //    testimonial.IsApproved = true;

        //    return RedirectToAction("Index");
        //}

        public IActionResult Add()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user, string password2)
        {
            ViewBag.username = user.Username;
            ViewBag.email = user.Email;

            if (user.Password == null || !user.Password.Equals(password2))
            {
                
                ViewBag.message = "Passwords do not match";
                return View();
            }

            if (user.Password.Length < 5 || user.Password.Length >15 || user.Password.Count(c=> Char.IsDigit(c)) < 1)
            {
                
                ViewBag.message = "Your password must be between 5 and 15 characters long and contain atleast 1 number";
                return View();
            }
               
            UserData.Add(user);
            return Redirect("Index/"+ user.ID);

        }

    }

}