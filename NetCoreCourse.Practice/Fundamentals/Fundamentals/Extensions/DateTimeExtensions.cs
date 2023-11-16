using System;

namespace Fundamentals.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateOnly AddDayOnly(this DateTime dateTime,int index)
        {
            return DateOnly.FromDateTime(dateTime.AddDays(index));
        }
    }
}
