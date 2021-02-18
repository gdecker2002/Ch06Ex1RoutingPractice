using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RoutingPractice.Areas.Admin.Controllers;

namespace RoutingPractice.Areas.Admin.Controllers
{
    public class Dummy3Controller : Controller
    {
        [Area("Admin")]
        public IActionResult DummyCustomAttributeRoute()
        {
            return View();
        }
    }
}
