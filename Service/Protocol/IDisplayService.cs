using System;

namespace Service.Protocol
{
    public interface IDisplayService
    {
        string GetFullName(DayOfWeek dayOfWeek);

        string GetShortName(DayOfWeek dayOfWeek);
    }
}