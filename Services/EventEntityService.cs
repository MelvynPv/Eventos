using Curso2_BuenasPracticas.Models;
using Curso2_BuenasPracticas.Services.Interfaces;
using Curso2_BuenasPracticas.Utils;
using System;
using System.Collections.Generic;

namespace Curso2_BuenasPracticas.Services
{
    public class EventEntityService
    {
        /// <summary>
        /// Retorna los eventos del documento.
        /// </summary>
        /// <param naLista de entidades de evento.</returns>
        public List<EventEntity> GetEventEntities(string events) {
            List<EventEntity> eventEntities = new List<EventEntity>();
            string[] eventsArray = events.Split('\n');
            foreach(string eventStirng in eventsArray)
            {
                string[] keyValueEvent = eventStirng.Split(',');
                eventEntities.Add(new EventEntity() { Title = keyValueEvent[0], DateStart = DateTime.Parse(keyValueEvent[1]) });
            }
            return eventEntities;
        }


        public IMessageFormat GetFormatMessage(bool isPass) 
        {
            if (isPass)
            {
                return new FormatPass();
            }

            return new FormatFuture();
        }

        public ITimeFormat GetTimeFormat(TimeFormat timeFormat) {
            switch (timeFormat)
            {
                case TimeFormat.Minutos:
                    return new FormatTimeInMinutes();
                    break;
                case TimeFormat.Horas:
                    return new FormatTimeInHours();

                    break;
                case TimeFormat.Dias:
                    return new FormatTimeDays();

                    break;
                case TimeFormat.Meses:
                    return new FormatTimeMounts();
                    break;
                default:
                    return new FormatTimeInMinutes();
                    break;
            }
        }

        public TimeFormat GetTimeEnum(DateTime dateTime)
        {

            var time = dateTime.Subtract(DateTime.Now);

            if (Math.Abs(time.TotalMinutes) < 60)
            {
                return TimeFormat.Minutos;
            }
            else if (Math.Abs(time.TotalHours) < 24)
            {
                return TimeFormat.Horas;
            }
            else if (Math.Abs(time.TotalDays) < 30)
            {
                return TimeFormat.Dias;
            }

            return TimeFormat.Meses;
        }
    }
}
