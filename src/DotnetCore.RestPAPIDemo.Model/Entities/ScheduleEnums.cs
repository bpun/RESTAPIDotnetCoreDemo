using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetCore.RestPAPIDemo.Model.Entities
{
    public class ScheduleEnums
    {
        public enum ScheduleType
        {
            Work = 1,
            Coffee = 2,
            Doctor = 3,
            Shopping = 4,
            Other = 5
        }

        public enum ScheduleStatus
        {
            Valid = 1,
            Cancelled = 2
        }
    }
}
