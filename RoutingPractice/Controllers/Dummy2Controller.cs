using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingPractice.Controllers
{
    public class Dummy2Controller : Controller
    {
        public IActionResult DummyCustomRoute(int id = 3, string category = "Slappy Hand", int page = 1)
        {
            return View();
        }
    }
}
