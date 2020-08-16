using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mens2020.DataSource.Models
{
    class UserEvent: DbMigration
    {
        [Key]
        [Required]

        public int UserEventId { get; set; }

        [Required]
        public int EventTypeId { get; set; }

        public int ParentId { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public string EventTitle { get; set; }
        public string EventText { get; set; }
        public int ColorID { get; set; }
        public DateTime ModificationDatetime { get; set; }
        public int RevisionID { get; set; }
        public int RecurID { get; set; }

        public override void Up()
        {

        }

    }
}
