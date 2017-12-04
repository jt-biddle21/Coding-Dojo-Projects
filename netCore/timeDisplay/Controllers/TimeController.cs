using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace timeDisplay.Controllers
{
    public class TimeController : Controller
    {
        [HttpGetAttribute]
        [Route("")]
        public IActionResult Index()
        {

            return View();  
        }
    }
}