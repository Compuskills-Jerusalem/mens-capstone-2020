using Mens2020.DataSource.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mens2020.Mvc.Models
{
    public class CreateGoalModel
    {




        public string UserEventId { get; set; }


        public int EventTypeId { get; set; }

        public int? ParentId { get; set; }


        public DateTime CreationDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public string EventTitle { get; set; }
        public string EventText { get; set; }
        public int ColorID { get; set; }
        public DateTime? ModificationDatetime { get; set; }
        //[errormessages()]
        public int RevisionID { get; set; }
        public int RecurID { get; set; }
        public IEnumerable<UserEvent> UserEvents { get; set; }
   
    }
}