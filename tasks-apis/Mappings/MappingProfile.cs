using AutoMapper;
using tasks_apis.Dtos;
using tasks_apis.Models;

namespace tasks_apis.Mappings
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            CreateMap<TaskModel, CreateTaskDTO>();
            CreateMap<CreateTaskDTO, TaskModel>();
        }
    }
}
