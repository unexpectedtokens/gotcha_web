using System.Collections.Generic;
using System;
using gotcha_web.database;
using gotcha_web.Forms;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace gotcha_web.Models
{
    public class GameLeader : User
    {
        public List<Elimination> Eliminations {get; set;}
        public Player PlayerAccount {get;set;}
        public GameLeader()
        {
            Eliminations = new List<Elimination>();
        }


        public GameLeader(Player playerAccount){
            this.alias = playerAccount.alias;
            this.email = playerAccount.email;
            this.password = playerAccount.password;
            this.firstname = playerAccount.firstname;
            this.lastname = playerAccount.lastname;
            this.PlayerAccount = playerAccount;
            this.Eliminations = new List<Elimination>();
        }
        public void AddPlayerToGame(Player player, Game game)
        {
            if(game.GameLeader.alias == player.alias){
                throw new Exception("Je kan niet deelnemen aan je eigen spel");
            }
            game.AddPlayer(player);
        }

        public void CreateGame(GotchaDBContext ctx, GameCreateForm form){
            var game = new Game();
            //var gt = ctx.Gametypes.Find(form.gametypeid);
            // if (gt == null)
            // {
            //     throw new Exception("Geen gametype met de opgegeven id");
            // }
            game.SetGameSpecification(this, form.Title, form.Description, form.Region);
            if(!game.CheckGameSpecification())
            {
                throw new Exception("Validation error");
            }else{
                ctx.Games.Add(game);
            }
        }

        public void CreateWordGame(GotchaDBContext ctx, GameCreateForm form)
        {
            var game = new WordGame();
            game.SetGameSpecification(this, form.Title, form.Description, form.Region, form.WordString);
            if (!game.CheckGameSpecification())
            {
                throw new Exception("Validation error");
            }else{
                ctx.WordGames.Add(game);
            }
        }
        public void StartGame(Game game, string alias, string loggedinas, GotchaDBContext ctx){
            if (game.userIsOwner(alias, loggedinas)){
                game.GenerateContracts(ctx);
                game.Start();
                ctx.SaveChanges();
            }else{
                throw new Exception("Spelleider is geen eigenaar van deze game");
            }
            
        }

        public void StartWordGame(WordGame game, string alias, string loggedinas, GotchaDBContext ctx)
        {
           if (game.userIsOwner(alias, loggedinas)){
               try{
                   game.GenerateContracts(ctx);
                    game.Start();
                    ctx.SaveChanges();
               }catch(Exception e){
                   Console.WriteLine(e);
               }
                
            }else{
                throw new Exception("Spelleider is geen eigenaar van deze game");
            } 
            
        }


        
        public static GameLeader FindByID(string alias, GotchaDBContext ctx)
        {
            return ctx.GameLeaders.Where(g => g.alias == alias).FirstOrDefault();
        }
    }
}