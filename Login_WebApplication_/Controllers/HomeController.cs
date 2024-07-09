using Microsoft.AspNetCore.Mvc;
using MVCWebApplication.Models;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using dddata;

namespace MVCWebApplication.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public IActionResult LoginForm()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Verify(Inputviewmodel model)
        {

            if (model.email == "admin" && model.password == "admin")
            {
                return View("Index");
            }
            else 
            {
                
				return View("Error");
			}

            
        }
        public IActionResult New_Index() 
        {
            return View();
        }
        public IActionResult nofusers()
        {

            
            Dynamicdata ddobj = new Dynamicdata();
            string noofusers = ddobj.nofusers();
            
            ViewBag.noofusers = noofusers;
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}