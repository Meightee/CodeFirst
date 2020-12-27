using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst2.Data.Models
{
    public class PlayerStatistic
    {
        [ForeignKey(nameof(Player))]
        public int PlayerId { get; set; }

        [ForeignKey(nameof(Game))]
        public int GameId { get; set; }

        public int Assist { get; set; }
        public int MinutesPlayed { get; set; }
        public int ScoredGoals { get; set; }

        public virtual Player Player { get; set; }
        public virtual Game Game { get; set; }
    }
}