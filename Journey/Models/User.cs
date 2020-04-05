using System.ComponentModel.DataAnnotations.Schema;

namespace Journey.Models
{
    public class User
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string Username { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string Password { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string RefreshToken { get; set; }
    }
}