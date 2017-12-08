using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DbConnection;
using System.Linq;

namespace quotingDojo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("/quotes")]
        public IActionResult Quotes()
        {
            List<Dictionary<string, object>> Joined = DbConnector.Query("SELECT name, content, created_at FROM users JOIN quote ON users.id = quote.user_id");
            ViewBag.objects = Joined;
            return View();
        }
        [HttpPost]
        [Route("/quoting")]
        public IActionResult Quoting(string name, string quote)
        {
            string quoter = name;
            string content = quote;
            if (quoter == null && content == null)
            {
                return RedirectToAction("Quotes");
            }
            else
            {
                List<Dictionary<string, object>> Users = DbConnector.Query($"INSERT INTO users (name) VALUES ('{name}')");
                List<Dictionary<string, object>> SpecificUser = DbConnector.Query($"SELECT * FROM users WHERE name = '{name}'");
                int id = (int)SpecificUser[0]["id"];
                DbConnector.Query($"INSERT INTO quote (content, created_at, user_id) VALUES ('{content}', NOW(), {id})");
                return RedirectToAction("Quotes");
            }
        }
    }
}
