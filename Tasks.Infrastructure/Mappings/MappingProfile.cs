using AutoMapper;
using Tasks.Common.Models;
using Tasks.Common.ViewModels;

namespace Tasks.Infrastructure.Mappings
{
    internal class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaskModel, CreateTaskDto>();
            CreateMap<CreateTaskDto, TaskModel>();
            //CreateProjection<TaskModel,CreateTaskDto>()
            //    .ForMember(dest=>dest.Text,opt=>opt.MapFrom(src=>src.Text))
            //    .ForMember(dest=>dest.ExternalInternal,opt=>opt.MapFrom(src=> src.ExternalInternal + " " + src.Text));
        }
    }
}
