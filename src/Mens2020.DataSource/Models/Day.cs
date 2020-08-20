using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mens2020.DataSource.Models
{
   
        [Flags]
        public enum Day
        {
            None = 0,
            Monday = 2,
            Tuesday = 4,
            Wednesday = 8,
            Thursday = 16,
            Friday = 32,
            Saturday = 64,
            Sunday = 128,
            Weekdays = Day.Monday | Day.Tuesday | Day.Wednesday | Day.Thursday | Day.Friday,
            Weekends = Day.Saturday | Day.Sunday,
            AllDaysOfWeek = Weekdays | Weekends






        }
        //Day UserEventRecurrence;
        //UserEventRecurrence = Day.Friday | Day.Monday | Day.Tuesday;
        //    int bitvaluse = (int)UserEventRecurrence;
        //Day readvaule = (Day)bitvaluse;
   
}