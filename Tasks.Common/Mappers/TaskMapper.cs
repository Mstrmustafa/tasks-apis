using Tasks.Common.Models;
using Tasks.Common.ViewModels;

namespace Tasks.Common.Mappers
{
    public static class TaskMapper
    {
        public static TaskModel ToInternal(this CreateTaskDto source)
        {
            return new TaskModel
            {
                ExternalInternal = source.ExternalInternal,
                Text = source.Text,
                Level = source.Level,
                Timing = source.Timing,
            };
        }
    }
}
