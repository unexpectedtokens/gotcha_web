using System.Collections.Generic;
using System;
using gotcha_web.database;
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
            game.Players.Add(player);
        }


    }
}