using Curso2_BuenasPracticas.Models;
using Curso2_BuenasPracticas.Services;
using Curso2_BuenasPracticas.Services.Interfaces;
using Curso2_BuenasPracticas.Utils;
using System;
using System.IO;

namespace Curso2_BuenasPracticas
{
    class Program
    {
        static readonly string textFile = @"C:\Temp\Data\eventos.txt";
        static void Main(string[] args)
        {
            EventEntityService eventEntityService = new EventEntityService();

            if (File.Exists(textFile))
            {
                // Read entire text file content in one string    
                string text = File.ReadAllText(textFile);

                foreach (EventEntity eventEntity in eventEntityService.GetEventEntities(text))
                {
                    bool IsPass = eventEntity.DateStart.CompareTo(DateTime.Now) < 0;
                    IMessageFormat formatMessage = eventEntityService.GetFormatMessage(IsPass);
                    TimeFormat timeFormatEnum = eventEntityService.GetTimeEnum(eventEntity.DateStart);
                    ITimeFormat timeFormat = eventEntityService.GetTimeFormat(timeFormatEnum);
                    string message = formatMessage.CreateMessage(eventEntity, timeFormat);


                    Console.WriteLine(message);
                }
            }
        }
    }
}
