using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Mens2020;
using Microsoft.Ajax.Utilities;
using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mens2020.Mvc.Models
{

    
    public class Mens2020User : IdentityUser
    {

       
       
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime? AccountCreated { get; set; }


       
    }
}