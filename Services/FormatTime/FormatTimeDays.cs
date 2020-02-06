using Curso2_BuenasPracticas.Services.Interfaces;
using System;

namespace Curso2_BuenasPracticas.Services.FormatTime
{
    public class FormatTimeDays : ITimeFormat
    {
        public string GetTimeFormat(TimeSpan time)
        {
            return string.Format("{0:%d} Dias", time);
        }
    }
}
