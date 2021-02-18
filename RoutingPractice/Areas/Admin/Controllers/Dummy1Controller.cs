using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoutingPractice.Areas.Admin.Controllers;

namespace RoutingPractice.Areas.Admin.Controllers
{
    public class Dummy1Controller : Controller
    {
        [Area("Admin")]
        public IActionResult DummyDefault()
        {
            return View();
        }
    }
}
