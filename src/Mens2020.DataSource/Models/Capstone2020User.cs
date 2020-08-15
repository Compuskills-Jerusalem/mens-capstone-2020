using Microsoft.AspNet.Identity.EntityFramework;
using System;

namespace Mens2020.DataSource.Models
{
    public class Capstone2020User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? AccountCreated { get; set; }
    }
}
