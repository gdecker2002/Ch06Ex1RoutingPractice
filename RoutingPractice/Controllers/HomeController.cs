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
       // public IActionResult Index()
       // {
      //      return Content("Home");
       // }

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

        public IActionResult DummyDefault()
        {        
                return Content("Dummy Default");            
        }
        [Route("{Controller}/[action]/{id?}")]
        public IActionResult DummyCustomRouteRules(string id)
        {
                if (id == null)
                {
                    return Content("No Dummy ID given.");
                }
                else
                {
                    return Content("Dummy ID: " + id);
                }
            }

        [Route("{Controller}/[action]/{id?}/page{page}")]
        public IActionResult DummyCustomRouteAttributes(string page)
        {
         
                if (page == null)
                {
                    return Content("No Dummy Page given.");
                }          
                else
                {
                    return Content("Dummy Page: " + page);
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
