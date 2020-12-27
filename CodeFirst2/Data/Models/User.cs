using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst2.Data.Models
{
    public class User
    {
        public User()
        {
            Bets = new HashSet<Bet>();
        }

        [Key]
        public int UserId { get; set; }

        public int Balance { get; set; }

        [MaxLength(64)]
        public string Email { get; set; }

        [MaxLength(128)]
        public string Name { get; set; }

        public string Password { get; set; }

        [MaxLength(128)]
        public string Username { get; set; }

        public virtual ICollection<Bet> Bets { get; set; }
    }
}