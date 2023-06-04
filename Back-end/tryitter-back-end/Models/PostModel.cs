using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tryitter_back_end.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [MaxLength(300, ErrorMessage = "O texto deve ter no máximo 300 caracteres.")]
        public string? Content { get; set; }
        public string? Image { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }
}