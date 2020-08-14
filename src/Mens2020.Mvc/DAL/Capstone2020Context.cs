using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Mens2020.Mvc.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Mens2020.Mvc.DAL
{
   
    public class Capstone2020Context : IdentityDbContext<Mens2020User>
    {
        //public Capstone2020Context() : base("Capstone2020Context")
        //{

        //}
        public DbSet<UserEvents> UserEvents { get; set; }

       

    }
}