using CRWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CRWebsite.Controllers
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

        public ActionResult Register()
        {
            return View("Register");
        }
        /// <summary>
        /// Show data from register form here.
        /// </summary>
        /// <param name="registerModel"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SubmitRegister([FromForm] RegisterModel registerModel)
        {
            if (ModelState.IsValid)
            {                
                return View("Form",registerModel);
            }
            else
            {
                return RedirectToPage("Error");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}