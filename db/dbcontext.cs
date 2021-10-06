using Microsoft.EntityFrameworkCore;
using gotcha_web.Models;

namespace gotcha_web.database
{
    public class GotchaDBContext : DbContext{
        public GotchaDBContext(DbContextOptions<GotchaDBContext> options):base(options){
            
        }
        public DbSet<User> Users{get;set;}
        public DbSet<Player> Players{get;set;}
        public DbSet<GameLeader> GameLeaders {get;set;}
        public DbSet<Admin> Admins {get;set;}
        public DbSet<Game> Games {get;set;}
        public DbSet<Rule> Rules {get;set;}
        public DbSet<Contract> Contracts {get;set;}
        public DbSet<Elimination> Eliminations{get;set;}
        

        public DbSet<WordGame> WordGames {get;set;}
        public DbSet<WordContract> WordContracts {get;set;}
        public DbSet<GametypeRequest> GametypeRequests {get;set;}
        
        
    }




}

