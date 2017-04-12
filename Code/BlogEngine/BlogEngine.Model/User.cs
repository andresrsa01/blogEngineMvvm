using System.ComponentModel.DataAnnotations;

namespace BlogEngine.Model
{
public    class User
    {
        [Key]
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
