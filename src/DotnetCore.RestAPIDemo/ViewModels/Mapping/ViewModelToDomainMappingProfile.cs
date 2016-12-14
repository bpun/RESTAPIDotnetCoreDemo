using AutoMapper;
using DotnetCore.RestPAPIDemo.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DotnetCore.RestPAPIDemo.Model.Entities.ScheduleEnums;

namespace DotnetCore.RestAPIDemo.ViewModels.Mapping
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<ScheduleViewModel, Schedule>()
                  .ForMember(d => d.Type,
                    map => map.MapFrom(s => s.Type))
                  .ForMember(d => d.Status,
                    map => map.MapFrom(s => s.Status))
                   .ForMember(d => d.Attendees.ToArray(),
                   map => map.MapFrom(s => s.Attendees));         

        }   
    }
}
