using Service.Protocol;
using System;
using System.Globalization;

namespace Service
{
    public sealed class JapaneseDisplayService : IDisplayService
    {
        public string GetFullName(DayOfWeek dayOfWeek)
        {
            return new CultureInfo("ja-JP").DateTimeFormat.GetDayName(dayOfWeek);
        }

        public string GetShortName(DayOfWeek dayOfWeek)
        {
            return new CultureInfo("ja-JP").DateTimeFormat.GetShortestDayName(dayOfWeek);
        }
    }
}