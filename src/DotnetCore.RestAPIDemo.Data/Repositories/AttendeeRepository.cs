using DotnetCore.RestAPIDemo.Data.Context;
using DotnetCore.RestPAPIDemo.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DotnetCore.RestAPIDemo.Data.Abstract.IRepositories;

namespace DotnetCore.RestAPIDemo.Data.Repositories
{
    public class AttendeeRepository : EntityBaseRepository<Attendee>, IAttendeeRepository
    {
        public AttendeeRepository(SchedulerContext context)
       : base(context)
        { }
    }
}
