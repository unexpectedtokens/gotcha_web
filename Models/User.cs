

using gotcha_web.database;

namespace gotcha_web.Models
{
    public abstract class User{
        public int Id {get;set;}
        public string email {get;set;}
        public string password {get;set;}
        public string alias {get;set;}
        public string firstname {get;set;}
        public string lastname {get;set;}

        public string userImage {get;set;}
        public string toString(){
            return $"{firstname} {lastname}";
        }

        public bool AttemptAuthentication(string AttemptedPassword)
        {
            return password == AttemptedPassword;
        }

        
        
        
    }
}