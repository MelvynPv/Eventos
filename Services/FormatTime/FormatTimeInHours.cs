using Curso2_BuenasPracticas.Services.Interfaces;
using System;

namespace Curso2_BuenasPracticas.Services.FormatTime
{
    public class FormatTimeInHours : ITimeFormat
    {
        public string GetTimeFormat(TimeSpan time)
        {
            return string.Format("{0:%h} hora(s)", time);
        }
    }
}
