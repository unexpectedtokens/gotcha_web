
using System.Collections.Generic;
namespace gotcha_web.Models
{
    public class Player : User
    {
        public List<Elimination> Eliminations{get;set;}
        public List<Game> Games{get;set;}
        public Player()
        {
            Eliminations = new();
        }

        public Player(User user){
            
        }
        public int GetAmountOfEliminations()
        {
            return Eliminations.Count;
        }
    }
}