using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        
        // [InverseProperty("User")]
        // public List<Post>? Posts { get; set; } = default!;
    }
}