using Service.Protocol;
using System;

namespace Service
{
    public sealed class JapaneseDisplayService : IDisplayService
    {
        public string GetFullName(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return "日曜日";

                case DayOfWeek.Monday:
                    return "月曜日";

                case DayOfWeek.Tuesday:
                    return "火曜日";

                case DayOfWeek.Wednesday:
                    return "水曜日";

                case DayOfWeek.Thursday:
                    return "木曜日";

                case DayOfWeek.Friday:
                    return "金曜日";

                case DayOfWeek.Saturday:
                    return "土曜日";

                default:
                    return string.Empty;
            }
        }

        public string GetShortName(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return "日";

                case DayOfWeek.Monday:
                    return "月";

                case DayOfWeek.Tuesday:
                    return "火";

                case DayOfWeek.Wednesday:
                    return "水";

                case DayOfWeek.Thursday:
                    return "木";

                case DayOfWeek.Friday:
                    return "金";

                case DayOfWeek.Saturday:
                    return "土";

                default:
                    return string.Empty;
            }
        }
    }
}