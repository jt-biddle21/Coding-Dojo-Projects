using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojoLeague.Factory;
using dojoLeague.Models;
using Microsoft.AspNetCore.Http;

namespace dojoLeague.Controllers
{
    public class HomeController : Controller
    {
        private readonly NinjaFactory _Ninjafactory;
        private readonly DojoFactory _Dojofactory;
 
        public HomeController(NinjaFactory Nconnect, DojoFactory Dconnect)
        {
            _Ninjafactory = Nconnect;
            _Dojofactory = Dconnect;
        }

 
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("Ninjas")]
        public IActionResult AddNinja()
        {
            ViewBag.Ninjas = _Ninjafactory.ShowAllNinjas();
            ViewBag.Dojos = _Dojofactory.ShowAllDojos();
            return View();
        }

        [HttpGet]
        [Route("Dojos")]
        public IActionResult AddDojo()
        {
            ViewBag.Dojos = _Dojofactory.ShowAllDojos();
            return View();
        }

        [HttpPost]
        [Route("addNinja")]
        public IActionResult AddingN(Ninja T)
        {
            if (ModelState.IsValid)
            {
                _Ninjafactory.AddNinja(T);
                return RedirectToAction("Index");
            }
            return RedirectToAction("AddNinja");
        }

        [HttpPost]
        [Route("addDojo")]
        public IActionResult AddingD(Dojo T)
        {
            if (ModelState.IsValid)
            {
                _Dojofactory.AddDojo(T);
                return RedirectToAction("AddNinja");
            }
            return View("AddDojo");
        }

        [HttpGet]
        [Route("showNinja/{NinjaId}")]
        public IActionResult NinjaDetails(int NinjaId)
        {
            ViewBag.LilNinja = _Ninjafactory.ShowSpecificNinja(NinjaId);
            return View();
        }

         [HttpGet]
        [Route("showDojo/{DojoId}")]
        public IActionResult DojoDetails(int DojoId)
        {
            HttpContext.Session.SetInt32("DojosId", DojoId);
            ViewBag.Id = DojoId;
            ViewBag.DojoName = _Dojofactory.DojoTitle(DojoId);
            ViewBag.Ninjas = _Ninjafactory.ShowAllNinjas(); 
            ViewBag.TheDojo = _Dojofactory.ShowSpecificDojo(DojoId);
            return View();
        }

        [HttpGet]
        [Route("remove/{NinjaId}")]
        public IActionResult Removablility(int NinjaId)
        {
            _Ninjafactory.Remove(NinjaId);
            return RedirectToAction("AddNinja");
        }

        [HttpGet]
        [Route("recruit/{NinjaId}")]
        public IActionResult Recruitment(int NinjaId)
        {
            int x = (int)HttpContext.Session.GetInt32("DojosId");
            _Dojofactory.Recruit(NinjaId, x);
            HttpContext.Session.Clear();
            return RedirectToAction("AddNinja");
        }
    }
}
