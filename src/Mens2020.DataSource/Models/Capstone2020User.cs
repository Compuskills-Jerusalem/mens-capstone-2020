using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mens2020.DataSource.Models
{
    public class Capstone2020User : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime? AccountCreated { get; set; }

        public virtual ICollection<UserEvent> UserEvents { get; set; }
    }
}
