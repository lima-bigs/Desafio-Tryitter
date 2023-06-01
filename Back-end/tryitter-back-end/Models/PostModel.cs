using System.ComponentModel.DataAnnotations;

namespace tryitter_back_end.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string? Content { get; set; } = default!;
        public string? Image { get; set; } = default!;
        public int UserId { get; set; } = default!;
        public virtual User User { get; set; } = default!;
    }
}