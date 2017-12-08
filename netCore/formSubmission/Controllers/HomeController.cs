using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using formSubmission.Models;

namespace formSubmission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        // GET: /Home/
        [HttpPost]
        [Route("/logging")]
        public IActionResult Logging(string fName, string lName, int userAge, string userEmail, string userPassword)
        {
            User NewUser = new User
            {
                First_Name = fName,
                Last_Name = lName,
                Age = userAge,
                Email = userEmail,
                Password = userPassword,
            };
            if (!TryValidateModel(NewUser))
            {
                ViewBag.errors = ModelState.Values;
                return View();
            }
            else
            {
                return RedirectToAction("Logged");
            }
        }

        [HttpGet]
        [Route ("/loggedIn")]
        public IActionResult Logged()
        {
            return View();
        }
    }
}
