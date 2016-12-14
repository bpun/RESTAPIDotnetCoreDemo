using AutoMapper;
using DotnetCore.RestPAPIDemo.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DotnetCore.RestPAPIDemo.Model.Entities.ScheduleEnums;

namespace DotnetCore.RestAPIDemo.ViewModels.Mapping
{
    public class DomainToViewModelMappingProfile : Profile
    {
    
        protected override void Configure()
        {
            Mapper.CreateMap<Schedule, ScheduleViewModel>()
                .ForMember(vm => vm.Creator,
                    map => map.MapFrom(s => s.Creator.Name))
                .ForMember(vm => vm.Attendees, map =>
                    map.MapFrom(s => s.Attendees.Select(a => a.UserId)));

            Mapper.CreateMap<Schedule, ScheduleDetailsViewModel>()
                .ForMember(vm => vm.Creator,
                    map => map.MapFrom(s => s.Creator.Name))
                .ForMember(vm => vm.Attendees, map =>
                    map.UseValue(new List<UserViewModel>()))
                .ForMember(vm => vm.Status, map =>
                    map.MapFrom(s => ((ScheduleStatus)s.Status).ToString()))
                .ForMember(vm => vm.Type, map =>
                    map.MapFrom(s => ((ScheduleType)s.Type).ToString()))
                .ForMember(vm => vm.Statuses, map =>
                    map.UseValue(Enum.GetNames(typeof(ScheduleStatus)).ToArray()))
                .ForMember(vm => vm.Types, map =>
                    map.UseValue(Enum.GetNames(typeof(ScheduleType)).ToArray()));

            Mapper.CreateMap<User, UserViewModel>()
                .ForMember(vm => vm.Id,
                    map => map.MapFrom(u => u.Id))
                .ForMember(vm => vm.Name,
                    map => map.MapFrom(u => u.Name))
                .ForMember(vm => vm.Profession,
                    map => map.MapFrom(u => u.Profession))
                .ForMember(vm => vm.Avatar,
                    map => map.MapFrom(u => u.Avatar))
                .ForMember(vm => vm.SchedulesCreated,
                    map => map.MapFrom(u => u.SchedulesCreated.Count()));
        }
    }
}
