using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using Microsoft.Owin.Security.Provider;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Mens2020.Mvc.DAL;

namespace Mens2020.Mvc.Models
{
    public static class IdentityExtensions
    {
        public static string GetFirstName( this IIdentity identity)
        {
          //  var IdentityManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(new IdentityDbContext()));

           var MensManager = new UserManager<Mens2020User>(new UserStore<Mens2020User>(new Capstone2020Context()));
           
            var Currentid = HttpContext.Current.User.Identity.GetUserId();
           
          // var CurrentUser = IdentityManager.FindById(Currentid);

            
           var CurrentUser1 = MensManager.FindById(Currentid);
            var FirstName = CurrentUser1.FirstName;
            return FirstName;

        }
    }
}