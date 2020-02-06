using Curso2_BuenasPracticas.Services.Interfaces;
using System;

namespace Curso2_BuenasPracticas.Services
{
    public class FormatTimeInHours : ITimeFormat
    {
        public string GetTimeFormat(TimeSpan time)
        {
            return string.Format("{0:%h} horas", time);
        }
    }
}
