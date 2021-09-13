



namespace gotcha_web.Models
{
    public class User{
        public int Id {get;set;}
        public string email {get;set;}
        public string password {get;set;}
        public string alias {get;set;}
        public string firstname {get;set;}
        public string lastname {get;set;}

        public string userImage {get;set;}
        public string toString(){
            return $"email: {email}, alias: {alias}, fullname: {firstname} {lastname}";
        }
    }
}