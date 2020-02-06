using Curso2_BuenasPracticas.Services;
using Curso2_BuenasPracticas.Services.ConvertToEntity;
using Curso2_BuenasPracticas.Services.ConvertToEntity.Interfaces;
using Curso2_BuenasPracticas.Services.FormatMessage;
using Curso2_BuenasPracticas.Services.FormatTime;
using Curso2_BuenasPracticas.Services.Interfaces;
using Curso2_BuenasPracticas.Utils;

namespace Curso2_BuenasPracticas.Factorys
{
    /// <summary>
    /// Fabrica que retorna la creación de los servicios.
    /// </summary>
    public class ServicesFactory
    {
        public IMessageFormat GetFormatMessage(bool isPass)
        {
            if (isPass)
            {
                return new FormatPass();
            }

            return new FormatFuture();
        }

        public ITimeFormat GetTimeFormat(TimeFormat timeFormat)
        {
            switch (timeFormat)
            {
                case TimeFormat.Minutos:
                    return new FormatTimeInMinutes();
                case TimeFormat.Horas:
                    return new FormatTimeInHours();
                case TimeFormat.Dias:
                    return new FormatTimeDays();
                case TimeFormat.Meses:
                    return new FormatTimeMounts();
                default:
                    return new FormatTimeInMinutes();
            }
        }

        public IConvertToEventEntity GetConvert(string type)
        {
            switch (type)
            {
                case "file":
                    return new FileToEventEntity();
                default:
                    return null;
            }
        }
    }
}
