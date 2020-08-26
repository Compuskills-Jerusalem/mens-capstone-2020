using Mens2020.DataSource.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Mens2020.DataSource.DataSource
{
    public class Capstone2020Context : IdentityDbContext<Capstone2020User>
    {
        public Capstone2020Context(string nameOrConnectionstring) : base(nameOrConnectionstring)
        {


    
         }
        public Capstone2020Context() : base()
        {



        }

        public DbSet <UserEvent> UserEvents { get; set; }
        public static Capstone2020Context Create()
        {

            return new Capstone2020Context(nameof(Capstone2020Context));
        }
    }
}
