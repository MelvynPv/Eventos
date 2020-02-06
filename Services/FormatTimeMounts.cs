﻿using Curso2_BuenasPracticas.Services.Interfaces;
using System;

namespace Curso2_BuenasPracticas.Services
{
    public class FormatTimeMounts : ITimeFormat
    {
        public string GetTimeFormat(TimeSpan time)
        {
            int mounts = Math.Abs(time.Days) / 30;
            return string.Format("{0} meses", mounts);
        }
    }
}
