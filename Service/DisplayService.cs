using Service.Protocol;
using System;
using System.Globalization;

namespace Service
{
    public sealed class DisplayService : IDisplayService
    {
        public string GetFullName(DayOfWeek dayOfWeek)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(dayOfWeek);
        }

        public string GetShortName(DayOfWeek dayOfWeek)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetShortestDayName(dayOfWeek);
        }
    }
}