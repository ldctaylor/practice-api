using Microsoft.EntityFrameworkCore;
using practice_api.Models;

namespace practice_api.Data
{//this is a giant class that will allow me to search my database tables

    public class ApplicationDBContext : DbContext 
    {
        
        public ApplicationDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
            // adding base allows us to pass up the options into the ApplicationDBContext class
        {

        }

        public DbSet<Stock> Stock { get; set; }
            //DBSet is a fancy word for 'I'm gonna grab something out of the db and you need to do something with it - will return the data in whatever form we want
        public DbSet<Comment> Comments { get; set; }
    }
}
