using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst2.Data.Models
{
    public class Bet
    {
        [Key]
        public int BetId { get; set; }

        public int Amount { get; set; }

        [Required, ForeignKey(nameof(Game))]
        public int GameId { get; set; }

        public Prediction Prediction { get; set; }
        public DateTime DateTime { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public virtual Game Game { get; set; }
        public virtual User User { get; set; }
    }
}