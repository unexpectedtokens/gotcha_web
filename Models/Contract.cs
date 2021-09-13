


namespace gotcha_web.Models
{
    public class Contract{
        public int Id{get;set;}
        public Player Target{get;set;}
        public Player Assassin {get;set;}
        public Elimination Elimination{get;set;}
    }
}