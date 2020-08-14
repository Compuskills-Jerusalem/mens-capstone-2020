using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mens2020.Mvc.Models
{
    public class RecursionDate
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
            Sunday = 148,
            Weekdays = Day.Monday | Day.Tuesday | Day.Wednesday | Day.Thursday | Day.Friday,
            Weekends = Day.Saturday | Day.Sunday,
            AllDaysOfWeek = Day.Weekdays | Day.Weekends



        }
        public Day RecursionId;
    }
}