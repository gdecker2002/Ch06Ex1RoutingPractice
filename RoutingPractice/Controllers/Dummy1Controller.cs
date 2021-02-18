using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingPractice.Controllers
{
    public class Dummy1Controller : Controller
    {
        public IActionResult DummyDefault()
        {
            return View();
        }
    }
}
