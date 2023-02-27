using System.ComponentModel.DataAnnotations;

namespace moment4_csharp.Models
{
    public class Songs
    {
        // props

        public int Id { get; set; }
        [Required]
        public string? Artist { get; set; }
        [Required]
        public string? Title { get; set; }

        public int Time { get; set; }
        [Required]
        public string? Category { get; set; }

    }
}
