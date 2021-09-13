using System.Collections.Generic;


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
        public int GetAmountOfEliminations(){
            return Eliminations.Count;
        }
    }
}