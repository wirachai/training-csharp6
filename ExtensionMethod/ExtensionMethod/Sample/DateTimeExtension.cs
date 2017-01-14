using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.Sample
{
    public static class DateTimeExtension
    {
        public static bool Between(this DateTime source, DateTime beginRange, DateTime endRange)
        {
            return source.Ticks >= beginRange.Ticks && source.Ticks <= endRange.Ticks;
        }
        public static bool WorkingDay(this DateTime source)
        {
            return source.DayOfWeek != DayOfWeek.Saturday && source.DayOfWeek != DayOfWeek.Sunday;
        }
        public static bool IsWeekend(this DateTime source)
        {
            return source.DayOfWeek == DayOfWeek.Saturday || source.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}
