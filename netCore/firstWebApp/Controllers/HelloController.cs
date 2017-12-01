using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace firstWebApp.Controllers
{
    public class HelloController : Controller
    {
        [HttpGetAttribute, Route("/{firstName}/{lastName}/{age}/{color}")]
        public JsonResult CallingCard(string firstName, string lastName, int age, string color)
        {   
            return Json(new {First_Name = firstName, Last_Name = lastName, Age = age, Color = color});
        }
    }
}
