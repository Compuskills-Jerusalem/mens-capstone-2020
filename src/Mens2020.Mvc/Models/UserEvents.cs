using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static Mens2020.Mvc.Models.RecursionDate;

namespace Mens2020.Mvc.Models
{
    public class UserEvents
    {
        [Key]
        public int UserEventID { get; set; }
        public int EventTypeID { get; set; }
        public int ParentId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime CompletedDate { get; set; }

        //[Display(Name = "Mens2020User")]
        //public virtual int Id { get; set; }

        //[ForeignKey("Id")]
        //public virtual Mens2020User Mens2020User { get; set; }

        //public virtual  Id { get; set; }

        public string EventTitle { get; set; }
        public string EventText { get; set; }
        public int ColorId { get; set; }
        public int ModificationDateTime { get; set; }

        public int RevisionID { get; set; }
        public Day RecusionId { get; set; }
    }
}