using System.ComponentModel.DataAnnotations;

namespace Tasks.Common.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        [Required]
        public string? Text { get; set; }

        [Required]
        public string? Level { get; set; }

        [Required]
        public string? ExternalInternal { get; set; }

        [Required]
        public DateOnly? Timing { get; set; }
        public string? ImgSrc { get; set; }
    }
}
