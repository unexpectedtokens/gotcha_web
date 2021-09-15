using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using Microsoft.Extensions.Logging;
using gotcha_web.Models;
using Microsoft.AspNetCore.Http;
using gotcha_web.database;

namespace gotcha_web.Controllers
{
    public class DashboardController : Controller
    {
        private readonly GotchaDBContext _ctx;
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ILogger<DashboardController> logger, GotchaDBContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            var alias = HttpContext.Session.GetString("alias");
            if (String.IsNullOrEmpty(alias)){
                return Redirect("/Auth");
            }
            ViewData["user"]  = _ctx.Users.Where(x => x.alias == alias).FirstOrDefault().toString();
            return View();
        }

        public IActionResult ProfileDetail(){
            return View("Profile/index");
        }

        public IActionResult Games(){
            var alias = HttpContext.Session.GetString("alias");
            if (String.IsNullOrEmpty(alias)){
                return Redirect("/Auth");
            }
            ViewData["games"] = _ctx.Games.ToList();
            return View("Game/index");
        }

        public IActionResult Logout(){
            HttpContext.Session.SetString("alias", "");
            return Redirect("/Auth");
        }
        
    }
}
