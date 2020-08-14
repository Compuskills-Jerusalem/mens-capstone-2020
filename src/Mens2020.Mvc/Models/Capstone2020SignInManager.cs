using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mens2020.Mvc.Models
{
    public class Capstone2020SignInManager : SignInManager<Mens2020User, string>
    {
        public Capstone2020SignInManager(Capstone2020UserManager userManager, IAuthenticationManager authenticationManager) : base(userManager, authenticationManager)
        {
        }
    }
}