using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static Mens2020.Mvc.Models.RecursionDate;

namespace Mens2020.Mvc.Models
{
    public class UserEventModels
    {
        [Key]
        public string UserEventId { get; set; }
        public int EventTypeId { get; set; }
        public int ParentId { get; set; }

        public string UserId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? CompletedDate { get; set; }

        public int ColorValue { get; set; }

        [Display(Name = "Goal")]
        public string EventTitle { get; set; }

        [Display(Name = "Description")]
        public string EventText { get; set; }

        [Display(Name = "Color")]
        public int ColorId { get; set; }
        public int ModificationDateTime { get; set; }

        public int RevisionID { get; set; }

        [Display(Name = "Repeats")]
        public Day RecusionId { get; set; }

        public int RecurIntValue { get; set; }
        public bool SundayClickedBool { get; set; }
        public bool MondayClickedBool { get; set; }
        public bool TuesdayClickedBool { get; set; }
        public bool WednesdayClickedBool { get; set; }
        public bool ThursdayClickedBool { get; set; }
        public bool FridayClickedBool { get; set; }
        public bool SaturdayClickedBool { get; set; }
        public bool EverydayClickedBool { get; set; }
    }
}