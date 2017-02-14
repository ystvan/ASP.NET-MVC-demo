using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BobDemoMVC.Models;

namespace BobDemoMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Simplest way to inject data to view (not the best) is to use the viewBag with dynamic properties:
            
            ViewBag.MyMethod = "what is this";


            //OR

            //Make a call out
            var cars = HelloModel.GetCars();

            // returns a ViewResult object (of type: ActionResult) that renders a view to the response
            // this case: \Views\Home\Index.cshtml

            //TODO: 1 of the overload pass an "object graph" into the View #2nd way

            return View(cars);
        }
    }
}