using Microsoft.AspNetCore.Mvc;
using RoutingPractice.Models;
using System.Collections.Generic;
using System.Linq;

namespace RoutingPractice.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return Content("Privacy");
        }

        public IActionResult Display(string id)
        {
            if (id == null)
            {
                return Content("No ID supplied.");
            }
            else
            {
                return Content("ID: " + id);
            }
        }

        [Route("[action]/{start}/{end?}/{message?}")]
        public IActionResult Countdown(int start, int end = 0, string message = "")
        {
            
            string contentString = "Counting down:\n";
            for(int i = start; i >= end; i--)
            {
                contentString += i + "\n";
                if (i == end)
                {
                    contentString += (message + "\n");
                }
            }
           
            return Content(contentString);
        }
    }
}
