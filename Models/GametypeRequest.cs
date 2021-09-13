

namespace gotcha_web.Models
{
    public class GametypeRequest
    {
        public int GameTypeRequestId {get;set;}
        public string Description {get;set;}
        public GameLeader GameLeader{get;set;}
    }
}