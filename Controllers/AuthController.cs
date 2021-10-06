using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using gotcha_web.Models;
using gotcha_web.database;





namespace gotcha_web.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GotchaDBContext _ctx;
        public AuthController(ILogger<HomeController> logger, GotchaDBContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("alias"))){
                return Redirect("/");
            }
            return View();
        }


        public class LoginFormModel{
            public string email {get;set;}
            public string password {get;set;}
            public bool loginAsGameLeader {get;set;}
        }
        [HttpPost]
        public IActionResult Index(LoginFormModel userFromForm)
        {   
            if(userFromForm.loginAsGameLeader)
            {
                var gl = _ctx.GameLeaders.Where(x=>x.email == userFromForm.email).FirstOrDefault();
                if (gl == null){
                    ViewData["autherror"] = "Er is geen spelleider gevonden met de ingevoerde email";
                    return View();
                }
                if(!gl.AttemptAuthentication(userFromForm.password)){
                    ViewData["autherror"] = "Incorrect wachtwoord";
                    return View();
                }
                HttpContext.Session.SetString("alias", gl.alias);
                HttpContext.Session.SetString("loggedinas", "gameleader");
            }else{
                var PlayerFromDB = _ctx.Players.Where(x=>x.email == userFromForm.email).FirstOrDefault();
                if(PlayerFromDB == null){
                    ViewData["autherror"] = "Er is geen speler gevonden met de ingevoerde email";
                    return View();
                }
                if(!PlayerFromDB.AttemptAuthentication(userFromForm.password)){
                    ViewData["autherror"] = "Incorrect wachtwoord";
                    return View();
                }
                HttpContext.Session.SetString("alias", PlayerFromDB.alias);
                HttpContext.Session.SetString("loggedinas", "player");   
            }    
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
    public IActionResult Register(Player userFromForm)
        {
            var userFromDBWhereEmail = _ctx.Users.Where(x=>x.email == userFromForm.email).FirstOrDefault();
            if(userFromDBWhereEmail != null){
                return View();
            }
            var userFromDBWhereAlias = _ctx.Users.Where(x=>x.email == userFromForm.email).FirstOrDefault();
            if(userFromDBWhereAlias != null){
                return View();
            }            
            _ctx.Players.Add(userFromForm);
            _ctx.SaveChanges();
            HttpContext.Session.SetString("alias", userFromForm.alias);
            HttpContext.Session.SetString("loggedinas", "player");
            return Redirect("/Dashboard");
        }

        
    }
}