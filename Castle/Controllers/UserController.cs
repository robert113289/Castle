using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Castle.Models;

namespace Castle.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            if (user.Password == null || !user.Password.Equals(verify))
            {
                ViewBag.username = user.Username;
                ViewBag.email = user.Email;
                ViewBag.message = "Passwords do not match";
                return View();
            }
            return View("Index");
        }

    }
    


}