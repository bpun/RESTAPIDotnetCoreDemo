﻿using DotnetCore.RestPAPIDemo.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore.RestPAPIDemo.Model.Entities
{
    public class Attendee : IEntityBase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }
    }
}
