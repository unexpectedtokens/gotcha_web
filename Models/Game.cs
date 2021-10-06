
using Microsoft.EntityFrameworkCore;
using gotcha_web.database;
using System.Collections.Generic;
using System.Linq;
using System;
namespace gotcha_web.Models
{
    public class Game{
        public int GameId {get;set;}

        public bool Active {get;set;}

        public string Title {get;set;}
        public string Description {get;set;}
        public string Region {get;set;}
        public bool Private {get;set;}
        
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
        public int GetContractCount()
        {
            return Contracts.Count;
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

        public void SetGameSpecification(GameLeader gameLeader, string title, string description, string region)
        {
            GameLeader = gameLeader;
            Region = region;
            Title = title;
            Description = description;

        }

       

        public void GenerateContracts(GotchaDBContext ctx)
        {
            
            ctx.Contracts.RemoveRange(Contracts);
            
            
            if (GetPlayerCount() < 3)
            {
                throw new Exception("Minimaal 3 spelers nodig om contracten aan te maken");
            }
            var list_players = new List<Player>(Players);
            var first = list_players[0];
            var contracts = new List<Contract>();
            for(int x = 0; x < list_players.Count;x++){
                
                var c = new Contract();
                c.Assassin = list_players[x];
                if (x == list_players.Count - 1 )
                {
                    c.Target = first;
                } else {
                    c.Target = list_players[x + 1];
                }
                c.Elimination = null;
                ctx.Contracts.Add(c);
                contracts.Add(c);
                ctx.SaveChanges();
            }
            Contracts = contracts;
        }

        public virtual bool CheckGameSpecification()
        {
            return true;
        }

        public void Start(){
            Active = true;
            
        }
    }
}