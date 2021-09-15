


using System.Collections.Generic;
namespace gotcha_web.Models
{
    public class Game{
        public int GameId {get;set;}

        public string Title {get;set;}
        public string Description {get;set;}
        public string Region {get;set;}
        public bool Public {get;set;}
        public Gametype Gametype {get;set;}
        public ICollection<Rule> Rules {get;set;}
        public ICollection<Player> Players{get;set;}
        public GameLeader GameLeader{get;set;}
        public Game()
        {
            Rules = new List<Rule>{};
        }

    }
}