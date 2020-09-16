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

    public static class DayExtentions
    {

        public static Day ConvertToDay(this DayOfWeek source)
        {
            switch (source)
            {
                case DayOfWeek.Sunday:
                    return Day.Sunday;

                case DayOfWeek.Monday:
                    return Day.Monday;

                case DayOfWeek.Tuesday:
                    return Day.Tuesday;

                case DayOfWeek.Wednesday:
                    return Day.Wednesday;

                case DayOfWeek.Thursday:
                    return Day.Thursday;

                case DayOfWeek.Friday:
                    return Day.Friday;

                case DayOfWeek.Saturday:
                    return Day.Saturday;

                default:
                    return Day.None;
            }
        }
       


    }
    

}