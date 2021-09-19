
using Microsoft.EntityFrameworkCore;
using gotcha_web.database;
using System.Collections.Generic;
using System.Linq;
namespace gotcha_web.Models
{
    public class Game{
        public int GameId {get;set;}

        public string Title {get;set;}
        public string Description {get;set;}
        public string Region {get;set;}
        public bool Private {get;set;}
        public Gametype Gametype {get;set;}
        public ICollection<Rule> Rules {get;set;}
        public ICollection<Player> Players{get;set;}

        public ICollection<Contract> Contracts{get;set;}
        public GameLeader GameLeader{get;set;}
        public Game()
        {
            Rules = new List<Rule>{};
        }

        public int GetPlayerCount()
        {
            return Players.Count;
        }

        public static Game GetByID(int id, GotchaDBContext ctx)
        {
            return ctx.Games.Include(g => g.Players).Include(g => g.GameLeader).Include(g => g.Contracts).Where(g => g.GameId == id).FirstOrDefault();
        }

        public bool userIsOwner(string alias, string loggedinas){
            var owner = false;
            if(loggedinas == "admin"){
                owner = true;
            }
            
            if(alias == GameLeader.alias){
                owner = true;
            }
            
            return owner;
        }

        public bool isPlayerInGame(string alias)
        {
            var inGame = false;
            foreach(var u in Players)
            {
                if( u.alias == alias)
                {
                    inGame = true;
                }
            }
            return inGame;
        }
        public void AddPlayer(Player player){
            this.Players.Add(player);
        }
        public bool isPlayerEliminated(string alias)
        {
            var eliminated = false;
            foreach (var c in Contracts)
            {
                if(c.Target.alias == alias){
                    if(c.Elimination!=null)
                    {
                        eliminated = true;
                    }
                }
            }
            return eliminated;
        }

        public void SetGameSpecification(Gametype gametype, GameLeader gameLeader, string title, string description, string region)
        {
            Gametype = gametype;
            GameLeader = gameLeader;
            Region = region;
            Title = title;
            Description = description;

        }

        public bool CheckGameSpecification()
        {
            return true;
        }

    }
}