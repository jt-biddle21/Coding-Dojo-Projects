using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace dojoSurvey.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.Example = "Hello World!";
            return View();
        }
        [HttpPost]
        [Route("/posting")]
        public IActionResult Display(string textField, string locationField, string languageField, string commentField)
        {
            ViewBag.Name = textField;
            ViewBag.Location = locationField;
            ViewBag.Language = languageField;
            ViewBag.Comment = commentField;
            return View();
        }
    }
}
