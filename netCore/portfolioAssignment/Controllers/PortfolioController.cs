using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace portfolioAssignment.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Homepage()
        {
            if (Request.Method == "POST")
            {
                return Redirect("/");
            }
            return View();
        } 
        [HttpGet]
        [Route("/contacts")]
        public IActionResult Contacts()
        {
            return View();
        }
        [HttpGet]
        [Route("/projects")]
        public IActionResult Projects()
        {
            return View();
        }
        [HttpPost]
        [Route("/sending")]
        public IActionResult Sending()
        {
            return Redirect("/");
        }
    }
}
