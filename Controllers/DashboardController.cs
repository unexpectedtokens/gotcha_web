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
using Microsoft.EntityFrameworkCore;
using gotcha_web.Forms;
using System.Web.Razor;

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

        public IActionResult Games(string search){
            Console.WriteLine(search);
            var alias = HttpContext.Session.GetString("alias");
            if (String.IsNullOrEmpty(alias)){
                return Redirect("/Auth");
            }
            ViewData["games"] = _ctx.Games.Include(g => g.GameLeader).Include(g => g.Players).ToList();
            return View("Game/index");
        }

        public class SearchForm{
            public string searchQ {get;set;}
        }
        public IActionResult FindGame()
        {
            return View("Game/Search");
        }

        [HttpPost]
        public IActionResult FindGame(SearchForm form)
        {
            
            return Redirect($"/Dashboard/Games?search={form.searchQ}");
        }

        public IActionResult GameDetail(int id)
        {
            var alias = HttpContext.Session.GetString("alias");
            var loggedinas = HttpContext.Session.GetString("loggedinas");
            if (String.IsNullOrEmpty(alias)){
                return Redirect("/Auth");
            }
            var game = Game.GetByID(id, _ctx);
            if(game == null){
                return Redirect("/Dashboard/Games");
            }
            ViewData["owner"] = game.userIsOwner(alias, loggedinas);
            ViewData["game"] = game;
            ViewData["playerInGame"] = game.isPlayerInGame(alias);
            return View("Game/Detail");
        }


        public IActionResult JoinGame(int id)
        {
            var game = Game.GetByID(id, _ctx);
            if (game == null)
            {
                return Redirect("/Dashboard/Games");
            }
            var alias = HttpContext.Session.GetString("alias");
            var loggedinas = HttpContext.Session.GetString("loggedinas");
            if(loggedinas == "admin"){
                return Redirect("/Dashboard/Games");
            }
            try{
                if(loggedinas == "gameleader")
                {
                    var gl = _ctx.GameLeaders.Where(g => g.alias == alias).Include(g => g.PlayerAccount).FirstOrDefault();
                    game.GameLeader.AddPlayerToGame(gl.PlayerAccount, game);

                }else{
                    var pl = _ctx.Players.Where(p => p.alias == alias).FirstOrDefault();
                    game.GameLeader.AddPlayerToGame(pl, game);
                }
                _ctx.SaveChanges();
            }catch(Exception e){
                Console.WriteLine(e);
            }
            return Redirect($"/Dashboard/GameDetail/{id}");
        }

        public IActionResult CreateGame(){
            var alias = HttpContext.Session.GetString("alias");
            var loggedinas = HttpContext.Session.GetString("loggedinas");
            if (String.IsNullOrEmpty(alias)){
                return Redirect("/Auth");
            }
            if (loggedinas=="player")
            {
                return Redirect("/Dashboard/Games");
            } 
            
            ViewBag.gametypes = _ctx.Gametypes.ToList();
            return View("Game/GameCreate");
        }


        

        [HttpPost]
        public IActionResult CreateGame(GameCreateForm form)
        {
            var alias = HttpContext.Session.GetString("alias");
            var loggedinas = HttpContext.Session.GetString("loggedinas");
            if (String.IsNullOrEmpty(alias)){
                return Redirect("/Auth");
            }
            if (loggedinas=="player")
            {
                return Redirect("/Dashboard/Games");
            }

            var gl = GameLeader.FindByID(alias, _ctx);
            try{
                gl.CreateGame(_ctx, form);
                _ctx.SaveChanges();
            }catch(Exception e){
                Console.WriteLine(e);
            }
            
            return Redirect("/Dashboard/Games");
        }
        public IActionResult Logout(){
            HttpContext.Session.SetString("alias", "");
            return Redirect("/Auth");
        }
        
    }
}
