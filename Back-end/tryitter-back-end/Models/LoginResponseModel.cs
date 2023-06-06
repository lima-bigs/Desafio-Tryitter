using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tryitter_back_end.Models
{
    public class LoginResponse
    {
        public User User { get; set; }
        public string Token { get; set; }
    }
}