
using gotcha_web.Models;

namespace gotcha_web.Forms
{
    public class GameCreateForm
    {
        public string Title {get;set;}
        public string Description {get;set;}
        public string Region {get;set;}

        public int gametypeid {get;set;}
        
    }
}