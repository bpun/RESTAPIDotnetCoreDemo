using DotnetCore.RestPAPIDemo.Model.Entities;

namespace DotnetCore.RestAPIDemo.Data.Abstract
{
    public class IRepositories
    {
        public interface IScheduleRepository : IEntityBaseRepository<Schedule> { }

        public interface IUserRepository : IEntityBaseRepository<User> { }

        public interface IAttendeeRepository : IEntityBaseRepository<Attendee> { }
    }
}
