using System.Collections.Generic;

using gotcha_web.database;
using Microsoft.EntityFrameworkCore;

using System.Linq;
using System;
namespace gotcha_web.Models{
    public class WordGame : Game{
        public ICollection<WordContract>  WordContracts {get;set;}

        new public static WordGame GetByID(int id, GotchaDBContext _ctx)
        {
            return _ctx.WordGames.Include(wg => wg.Players).Include(wg => wg.WordContracts).Include(gm => gm.GameLeader).Where(wg => wg.GameId == id).FirstOrDefault();
        }
        public string Words {get;set;}


        public WordGame(Game game){
            this.GameId = game.GameId;
            this.Title = game.Title;
            this.Active = game.Active;
            this.GameLeader = game.GameLeader;
            this.Description = game.Description;
            this.Players = game.Players;
            this.Private = game.Private;

        }

        public WordGame()
        {}


        new public int GetContractCount()
        {
            return WordContracts.Count;
        }

        new public bool isPlayerEliminated(string alias)
        {
            var eliminated = false;
            foreach (var c in WordContracts)
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
        public List<string> GetWords()
        {
            var arr = Words.Split(" ");
            Console.WriteLine(arr.Length);
            var stringList = new List<string>();
            foreach (var item in arr)
            {
                stringList.Add(item);
            }
            return stringList;
        }

        private string getRandomWord()
        {
            var rand = new Random();
            var randItem = GetWords()[rand.Next(GetWords().Count)];
            return randItem;
        }
        public void SetGameSpecification(GameLeader gameLeader, string title, string description, string region, string wordsString)
        {
            GameLeader = gameLeader;
            Title = title;
            Description = description;
            Region = region;
            Words = wordsString;
            
        }
        public override bool CheckGameSpecification()
        {
            var retVal = base.CheckGameSpecification();
            retVal = retVal && GetWords().Count > 3;
            return retVal;
        }
        new public void GenerateContracts(GotchaDBContext ctx)
        {
            ctx.WordContracts.RemoveRange(WordContracts);
            if (GetPlayerCount() < 3)
            {
                throw new Exception("Minimaal 3 spelers nodig om contracten aan te maken");
            }
            var list_players = new List<Player>(Players);
            var first = list_players[0];
            var contracts = new List<WordContract>();
            for(int x = 0; x < list_players.Count;x++){ 
                var c = new WordContract();
                c.Assassin = list_players[x];
                if (x == list_players.Count - 1)
                {
                    c.Target = first;
                } else {
                    c.Target = list_players[x + 1];
                }
                c.Elimination = null;
                c.Word = getRandomWord();
                ctx.WordContracts.Add(c);
                WordContracts.Add(c);
                ctx.SaveChanges();
            }
            ctx.SaveChanges();
        }
        public override WordContract GetPlayerContract(string alias)
        {
            WordContract wc = new();
            foreach (var item in WordContracts)
            {
                if(item.Assassin.alias == alias)
                {
                    wc = item;
                }
            }
            return wc;
        }
    }
}