using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using gotcha_web.Models;





namespace gotcha_web.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AuthController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("alias"))){
                return Redirect("/");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            Console.WriteLine(user.toString());
            user.alias = "daniel";
            HttpContext.Session.SetString("alias", user.alias);
            return Redirect("/Dashboard");
        }

        public IActionResult Register()
        {
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("alias"))){
                return Redirect("/");
            }
            return View();
        }

    [HttpPost]
    public IActionResult Register(User user)
        {
            Console.WriteLine(user.toString());
            HttpContext.Session.SetString("alias", user.alias);
            return Redirect("/Dashboard");
        }

        
    }
}