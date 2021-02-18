using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingPractice.Controllers
{
    public class Dummy3Controller : Controller
    {
        [Route("{Controller}/[action]/{id?}")]
        public IActionResult DummyCustomAttributeRoute(int id = 3)
        {
            return View();
        }
    }
}
