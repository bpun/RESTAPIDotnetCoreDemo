using DotnetCore.RestAPIDemo.Data.Context;
using DotnetCore.RestPAPIDemo.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DotnetCore.RestAPIDemo.Data.Abstract.IRepositories;

namespace DotnetCore.RestAPIDemo.Data.Repositories
{
    public class ScheduleRepository : EntityBaseRepository<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(SchedulerContext context)
       : base(context)
        { }
    }
}

