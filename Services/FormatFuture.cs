using Curso2_BuenasPracticas.Models;
using Curso2_BuenasPracticas.Services.Interfaces;
using System;

namespace Curso2_BuenasPracticas.Services
{
    public class FormatFuture : IMessageFormat
    {
        public string CreateMessage(IEventEntity eventEntity, ITimeFormat timeFormat)
        {
            TimeSpan timeDifference = eventEntity.DateStart.Subtract(DateTime.Now);

            return string.Format("{0} ocurrirá dentro de {1}", eventEntity.Title, timeFormat.GetTimeFormat(timeDifference));
        }
    }
}
