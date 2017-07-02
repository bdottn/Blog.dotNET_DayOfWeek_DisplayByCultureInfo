using Service.Protocol;
using System;

namespace Service
{
    public sealed class ChineseDisplayService : IDisplayService
    {
        public string GetFullName(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return "星期日";

                case DayOfWeek.Monday:
                    return "星期一";

                case DayOfWeek.Tuesday:
                    return "星期二";

                case DayOfWeek.Wednesday:
                    return "星期三";

                case DayOfWeek.Thursday:
                    return "星期四";

                case DayOfWeek.Friday:
                    return "星期五";

                case DayOfWeek.Saturday:
                    return "星期六";

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
                    return "一";

                case DayOfWeek.Tuesday:
                    return "二";

                case DayOfWeek.Wednesday:
                    return "三";

                case DayOfWeek.Thursday:
                    return "四";

                case DayOfWeek.Friday:
                    return "五";

                case DayOfWeek.Saturday:
                    return "六";

                default:
                    return string.Empty;
            }
        }
    }
}