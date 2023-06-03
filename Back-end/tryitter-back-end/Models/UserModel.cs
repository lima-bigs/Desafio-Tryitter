using System.ComponentModel.DataAnnotations;

namespace tryitter_back_end.Models
{
    public class User
    {
        [Key]
        public int? UserId { get; set; }
        public string Name { get; set; } = default!;
        public string? Password { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Modulo { get; set; } = default!;
        public string? Status { get; set; } = default!;
        
        public virtual List<Post>? Posts { get; set; } = default!;
    }
}