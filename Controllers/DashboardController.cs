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


namespace gotcha_web.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ILogger<DashboardController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (String.IsNullOrEmpty(HttpContext.Session.GetString("alias"))){
                return Redirect("/Auth");
            }
            return View();
        }

        
    }
}
