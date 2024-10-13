using System.ComponentModel.DataAnnotations;

namespace tasks_apis.Models
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
        public string? Timing { get; set; }
        public string? ImgSrc { get; set; }
    }
}
