using Microsoft.EntityFrameworkCore;
using gotcha_web.Models;

namespace gotcha_web.database
{
    public class GotchaDBContext : DbContext{
        public GotchaDBContext(DbContextOptions<GotchaDBContext> options):base(options){
            
        }
        public DbSet<User> Users{get;set;}
        
    }




}

