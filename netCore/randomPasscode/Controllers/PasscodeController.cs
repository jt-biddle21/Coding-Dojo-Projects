using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
 
namespace randomPasscode.Controllers
{
    public class PasscodeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            int? counter = HttpContext.Session.GetInt32("Count");
            counter = 0;
            counter += 1;
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!#%^&*";
            string passcode = "";
            Random rand = new Random();
            for(int i = 0;i < 15; i++)
            {
                passcode = passcode + chars[rand.Next(0, chars.Length)];
            }
            ViewBag.passcode = passcode;
            ViewBag.counter = counter;
            HttpContext.Session.SetInt32("Count", (int)counter);
            return View();
        }
    }
}
