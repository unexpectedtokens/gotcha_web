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



namespace gotcha_web.Controllers {
    public class DummyDataController : Controller
    {
        private readonly GotchaDBContext _ctx;
        private readonly ILogger<DashboardController> _logger;

        public DummyDataController(ILogger<DummyDataController> logger, GotchaDBContext ctx)
        {
            _ctx = ctx;
        }



        public IActionResult Index(){
            var player1 = new Player();
            player1.alias = "hansanders";
            player1.firstname = "hans";
            player1.lastname = "anders";
            player1.email = "hans@anders.nl";
            player1.password = "yes";
            _ctx.Players.Add(player1);
            var player2 = new Player();
            player2.alias = "kareljan";
            player2.firstname = "karel";
            player2.lastname = "jan";
            player2.email = "jan@karel.nl";
            player2.password = "yes";
            _ctx.Players.Add(player2);
            var player3 = new Player();
            player3.alias = "johnjohnson";
            player3.firstname = "john";
            player3.lastname = "johnson";
            player3.email = "john@johnson.nl";
            player3.password = "yes";
            _ctx.Players.Add(player3);
            _ctx.SaveChanges();
            var gl = new GameLeader(player1);
            _ctx.GameLeaders.Add(gl);
            _ctx.SaveChanges();
            var gt = new Gametype();
            gt.Description = "Make someone say a word to execute them";
            _ctx.Gametypes.Add(gt);
            _ctx.SaveChanges();
            var game = new Game();
            game.GameLeader = gl;
            game.Title = "best game ever";
            game.Gametype = gt;
            game.Public =true;
            game.Description ="Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatem id autem corporis vel qui! Error tenetur ea aliquam atque laudantium soluta quae dolorem, animi voluptate voluptatem doloremque, maiores quam et? Itaque et quo vero harum perferendis neque, pariatur eaque debitis cum voluptatem quod amet alias. Dicta vero maiores ab eum pariatur odio nemo officia fugit repellat voluptatum quis ratione consequatur atque est facilis, voluptas, in nihil! Enim impedit incidunt vitae excepturi dolore voluptate nulla repudiandae reprehenderit facere necessitatibus! A eos iste quam hic aspernatur! Tempora incidunt, consequuntur veritatis accusantium reiciendis earum est, nihil nulla laborum modi aliquid? Hic, mollitia quae!";
            _ctx.Games.Add(game);
            _ctx.SaveChanges();



            

            return Redirect("/");
        }

    }

}