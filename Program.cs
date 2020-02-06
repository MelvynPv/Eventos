using Curso2_BuenasPracticas.Factorys;
using Curso2_BuenasPracticas.Models;
using Curso2_BuenasPracticas.Services;
using Curso2_BuenasPracticas.Services.ConvertToEntity.Interfaces;
using Curso2_BuenasPracticas.Services.Interfaces;
using Curso2_BuenasPracticas.Utils;
using System;

namespace Curso2_BuenasPracticas
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicesFactory serviceFactory = new ServicesFactory();
            IConvertToEventEntity convert = serviceFactory.GetConvert("file");
            IMessageFormat formatMessage;
            ITimeFormat timeFormat;

            foreach (EventEntity eventEntity in convert.ConvertToEventEntity())
            {
                formatMessage = serviceFactory.GetFormatMessage(
                    DateTimeUtilities.DateIsPreviousToToday(eventEntity.DateStart));

                timeFormat = serviceFactory.GetTimeFormat(
                    DateTimeUtilities.GetTimeEnum(eventEntity.DateStart));

                //se crea el mensaje.
                string message = formatMessage.CreateMessage(eventEntity, timeFormat);


                Console.WriteLine(message);
            }

        }
    }
}
