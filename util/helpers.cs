using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace gotcha_web.util{
    public class Link{
        public string linktext{get;set;}
        public string path{get;set;}

        public Link(string text, string path)
        {
            linktext = text;
            this.path = path;
        }
    }

    public class ControllerHelper{
        

        public (string alias, string loggedinas) getContextVars(HttpContext ctx){
            var alias = ctx.Session.GetString("alias");
            var loggedinas = ctx.Session.GetString("loggedinas");
            return (alias, loggedinas);
        } 
    }
    

}