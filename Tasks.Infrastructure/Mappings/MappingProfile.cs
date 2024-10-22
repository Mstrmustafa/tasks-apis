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
        }
    }
}
