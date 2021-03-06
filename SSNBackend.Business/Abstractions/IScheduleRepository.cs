﻿using System.Collections.Generic;
using SSNBackend.DatabaseModel.Models;

namespace SSNBackend.Business.Abstractions
{
    public interface IScheduleRepository
    {
        IEnumerable<Schedule> Schedules { get; }
    }
}