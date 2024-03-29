﻿using DotnetCore.RestPAPIDemo.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DotnetCore.RestPAPIDemo.Model.Entities.ScheduleEnums;

namespace DotnetCore.RestPAPIDemo.Model.Entities
{
    public class Schedule : IEntityBase
    {
        public Schedule()
        {

        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime  TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public string Location { get; set; }
        public ScheduleType Type { get; set; }

        public ScheduleStatus Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public User Creator { get; set; }
        public int CreatorId { get; set; }
        public ICollection<Attendee> Attendees { get; set; }

    }
}
