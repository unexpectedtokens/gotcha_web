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
using gotcha_web.util;

namespace gotcha_web.Controllers
{
    public class DashboardController : Controller
    {
        private readonly GotchaDBContext _ctx;
        private readonly ILogger<DashboardController> _logger;

        private readonly ControllerHelper _helper;

        public DashboardController(ILogger<DashboardController> logger, GotchaDBContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
            _helper = new ControllerHelper();
        }

        public IActionResult Index()
        {
            var alias = _helper.getContextVars(HttpContext).alias;
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

        public IActionResult WordGameDetail(int id)
        {
            var alias = HttpContext.Session.GetString("alias");
            var loggedinas = HttpContext.Session.GetString("loggedinas");
            if (String.IsNullOrEmpty(alias)){
                return Redirect("/Auth");
            }
            var game = WordGame.GetByID(id, _ctx);
            if(game == null){
                return Redirect("/Dashboard/Games");
            }
            ViewData["isWordGame"] = true;
            ViewData["owner"] = game.userIsOwner(alias, loggedinas);
            ViewData["game"] = game;
            ViewData["playerInGame"] = game.isPlayerInGame(alias);
            return View("Game/WordGameDetail");
        }


        public IActionResult JoinGame(int id)
        {
            var game = Game.GetByID(id, _ctx);
            if (game == null)
            {
                return Redirect("/Dashboard/Games");
            }
            if (game.Active){
                return Redirect($"/Dashboard/GameDetail/{id}");
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

        

        public IActionResult Mygamespl(){
            var alias = HttpContext.Session.GetString("alias");
            
            if (String.IsNullOrEmpty(alias)){
                return Redirect("/Auth");
            }

            var games = _ctx.Games.Include(g => g.GameLeader).Include(g => g.Players).Where(g => g.Players.Any(p => p.alias == alias)).ToList();
            ViewData["games"] = games;
            return View("Game/Index");
        }

         public IActionResult Mygamesgl(){
            var alias = HttpContext.Session.GetString("alias");
            var loggedinas = HttpContext.Session.GetString("loggedinas");
            if (String.IsNullOrEmpty(alias) || loggedinas == "player"){
                return Redirect("/Auth");
            }

            ViewData["games"] = _ctx.Games.Include(g => g.GameLeader).Include(g => g.Players).Where(g => g.GameLeader.alias == alias).ToList();
            return View("Game/Index");
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
            
            //ViewBag.gametypes = _ctx.Gametypes.ToList();
            return View("Game/GameCreate");
        }

        // public IActionResult GenerateContracts(int id)
        // {
        //     var game = Game.GetByID(id, _ctx);
        //     if (game == null){
        //         Redirect("/Dashboard/Games");
        //     }
        //     var (alias, loggedinas) = _helper.getContextVars(HttpContext);
        //     Console.WriteLine($"output helper.getcontextvars: {alias}, {loggedinas}");
        //     if (loggedinas == "player")
        //     {
        //         Redirect("/Auth");
        //     }
        //     var gl = _ctx.GameLeaders.Where(gl => gl.alias == alias).FirstOrDefault();
        //     if (gl == null){
        //         Redirect("/Auth");
        //     }

        //     try{
        //         if(game.GetType().Name == "WordGame"){
        //             Console.WriteLine("Generating word contracts");
        //             var wordGame = WordGame.GetByID(game.GameId, _ctx);
        //             gl.GenerateWordContractsForGame(wordGame, alias, loggedinas, _ctx);
        //         }else{
        //             gl.GenerateContractsForGame(game, alias, loggedinas, _ctx);
        //         }
                
        //     }catch(Exception e){
        //         _logger.LogError(1, e, "error generating contracts");
        //     }
            
        //     return Redirect($"/Dashboard/GameDetail/{id}");
        // }
        

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
                if (form.gametype == "Woordspel"){
                    gl.CreateWordGame(_ctx, form);
                    _ctx.SaveChanges();
                } else {
                    gl.CreateGame(_ctx, form);
                    _ctx.SaveChanges();
                }
                
            }catch(Exception e){
                Console.WriteLine(e);
            }
            
            return Redirect("/Dashboard/Games");
        }
        public IActionResult Logout(){
            HttpContext.Session.SetString("alias", "");
            return Redirect("/Auth");
        }

        public IActionResult StartGame(int id){
            var game = Game.GetByID(id, _ctx);
            if (game == null){
                Console.WriteLine("game is null");
                return Redirect("/Dashboard/Games");
            }
            var (alias, loggedinas) = _helper.getContextVars(HttpContext);
            Console.WriteLine($"output helper.getcontextvars: {alias}, {loggedinas}");
            if (loggedinas == "player")
            {
                Console.WriteLine("logged in as player");
                return Redirect("/Auth");
            }
            var gl = _ctx.GameLeaders.Where(gl => gl.alias == alias).FirstOrDefault();
            if (gl == null){
                return Redirect("/Auth");
            }

            try{
                if(game.GetType().Name == "WordGame"){
                    Console.WriteLine("Generating word contracts");
                    var wordGame = WordGame.GetByID(game.GameId, _ctx);
                    if (wordGame == null){
                        Console.WriteLine("wordgame is null");
                        return Redirect("/Dashboard/Games");
                    }
                    gl.StartWordGame(wordGame, alias, loggedinas, _ctx);
                }else{
                    gl.StartGame(game, alias, loggedinas, _ctx);
                }
                
            }catch(Exception e){
                _logger.LogError(1, e, "error generating contracts");
            }
            return Redirect($"/Dashboard/GameDetail/{id}");
        }
        
    }
}
