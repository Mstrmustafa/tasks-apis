using Microsoft.Extensions.DependencyInjection;
using Tasks.Common.Repository;
//using Tasks.Common.Service;
using Tasks.Infrastructure.Repository;
using Tasks.Infrastructure.Service;

namespace Tasks.Infrastructure
{
    public static class InfrastructureServicesExtension
    {
        public static void AddInfrastuctureServices(this IServiceCollection services)
        {
            services.AddScoped<ITaskRepository, TaskRepository>();
            services.AddScoped<ITaskService, TaskService>();
        }
    }
}
