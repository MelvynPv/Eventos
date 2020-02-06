using Curso2_BuenasPracticas.Services.Interfaces;
using System;

namespace Curso2_BuenasPracticas.Services
{
    public class FormatTimeDays : ITimeFormat
    {
        public string GetTimeFormat(TimeSpan time)
        {
            return string.Format("{0:%d} Dias", time);
        }
    }
}
