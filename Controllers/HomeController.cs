using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyValidation.Models;

namespace DojoSurveyValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Results(Ninja ninja)
        {
            return View(ninja);
        }

        [HttpPost("NinjaSubmit")]
        public IActionResult NinjaSubmit(Ninja ninja)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Results", ninja);
            }
            else
            {
                return View("Index");
            }
        }

    }
}
