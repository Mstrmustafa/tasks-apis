using System.ComponentModel.DataAnnotations;

namespace tasks_apis.Dtos
{
    public class CreateTaskDTO
    {
        [Required]
        public string? Text { get; set; }

        [Required]
        public string? Level { get; set; }

        [Required]
        public string? ExternalInternal { get; set; }

        [Required]
        public string? Timing { get; set; }
    }



}
