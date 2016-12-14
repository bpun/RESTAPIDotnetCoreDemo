using DotnetCore.RestAPIDemo.Data.Context;
using DotnetCore.RestPAPIDemo.Model.Entities;
using static DotnetCore.RestAPIDemo.Data.Abstract.IRepositories;

namespace DotnetCore.RestAPIDemo.Data.Repositories
{
    public class UserRepository : EntityBaseRepository<User>, IUserRepository
    {
        public UserRepository(SchedulerContext context)
       : base(context)
        { }
    }
}
