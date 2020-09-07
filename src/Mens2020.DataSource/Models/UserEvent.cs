using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mens2020.DataSource.Models
    
{
    public class UserEvent
    {
        [Key]
        [Required]
        
        public string UserEventId { get; set; }

        [Required]
        public int EventTypeId { get; set; }

        public int ParentId { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }
        public DateTime? CompletedDate { get; set; }

        [Display(Name = "Goal")]
        public string EventTitle { get; set; }

        [Display(Name = "Description")]
        public string EventText { get; set; }

        [Display(Name = "Color")]
        public int ColorID { get; set; }
        public DateTime? ModificationDatetime { get; set; }
        public int RevisionID { get; set; }

        [Display(Name = "Repeats")]
        public int RecurID { get; set; }

        public IEnumerable<UserEvent> UserEvents { get; set; }

  
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Capstone2020User User { get; set; }

       
    }
}
