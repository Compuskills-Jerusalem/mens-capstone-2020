using Mens2020.Mvc.DAL;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mens2020.Mvc.Models
{
    public class Capstone2020UserManager : UserManager<Mens2020User>
    {
        public Capstone2020UserManager(IUserStore<Mens2020User> store) : base(store)
        { 
        
            
        
        }
        







        
    }
}