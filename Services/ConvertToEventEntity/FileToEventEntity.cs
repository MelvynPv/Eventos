using Curso2_BuenasPracticas.Models;
using Curso2_BuenasPracticas.Services.ConvertToEntity.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Curso2_BuenasPracticas.Services.ConvertToEntity
{
    /// <summary>
    /// Clase que se encarga de convertir un archivo a una lista de <see cref="EventEntity"/>
    /// </summary>
    public class FileToEventEntity : IConvertToEventEntity
    {
        static readonly string _textFileUrl = Path.GetFullPath("eventos.txt");

        /// <summary>
        /// Convierte el archivo a un alista de entidades.
        /// </summary>
        /// <returns></returns>
        public List<EventEntity> ConvertToEventEntity()
        {
            List<EventEntity> eventEntities = new List<EventEntity>();
            if (File.Exists(_textFileUrl))
            {
                // lee el archivo   
                string events = File.ReadAllText(_textFileUrl);

                string[] eventsArray = events.Split('\n');
                foreach (string eventStirng in eventsArray)
                {
                    string[] keyValueEvent = eventStirng.Split(',');
                    eventEntities.Add(new EventEntity() { Title = keyValueEvent[0], DateStart = DateTime.Parse(keyValueEvent[1]) });
                }
            }

            return eventEntities;
        }
    }
}
