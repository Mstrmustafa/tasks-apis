using System.ComponentModel.DataAnnotations;

namespace Tasks.Common.ViewModels
{
    public class CreateTaskDto
    {
        [Required]
        public string? Text { get; set; }

        [Required]
        public string? Level { get; set; }

        [Required]
        public string? ExternalInternal { get; set; }

        [Required]
        public DateOnly? Timing { get; set; }
    }
}
