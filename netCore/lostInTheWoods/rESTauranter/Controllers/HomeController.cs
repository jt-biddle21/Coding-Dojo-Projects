using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rESTauranter.Factory;
using rESTauranter.Models;

namespace rESTauranter.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrailFactory _Trailfactory;
 
        public HomeController(TrailFactory connect)
        {
            _Trailfactory = connect;
        }
 
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.trails = _Trailfactory.ShowAll();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        [Route("show/{TrailId}")]
        public IActionResult Details(int TrailId)
        {
            ViewBag.trail = _Trailfactory.ShowSpecific(TrailId);
            return View();
        }

        [HttpPost]
        [Route("addTrail")]
        public IActionResult NewTrail(Trail T)
        {
            if (ModelState.IsValid)
            {
                _Trailfactory.AddTrail(T);
                return RedirectToAction("Index");
            }
            return View("Add");
        }
    }
}
