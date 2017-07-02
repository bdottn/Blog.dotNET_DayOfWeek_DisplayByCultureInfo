using Service.Protocol;
using System;
using System.Globalization;

namespace Service
{
    public sealed class ChineseDisplayService : IDisplayService
    {
        public string GetFullName(DayOfWeek dayOfWeek)
        {
            return new CultureInfo("zh-TW").DateTimeFormat.GetDayName(dayOfWeek);
        }

        public string GetShortName(DayOfWeek dayOfWeek)
        {
            return new CultureInfo("zh-TW").DateTimeFormat.GetShortestDayName(dayOfWeek);
        }
    }
}