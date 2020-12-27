using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst2.Data.Models
{
    public class Game
    {
        public Game()
        {
            PlayerStatistics = new HashSet<PlayerStatistic>();
            Bets = new HashSet<Bet>();
        }

        [Key]
        public int GameId { get; set; }

        public int AwayTeamBetRate { get; set; }
        public int AwayTeamGoals { get; set; }

        [ForeignKey(nameof(AwayTeam))]
        public int AwayTeamId { get; set; }

        public int DrawBetRate { get; set; }
        public int HomeTeamBetRate { get; set; }
        public int HomeTeamGoals { get; set; }

        [ForeignKey(nameof(HomeTeam))]
        public int HomeTeamId { get; set; }

        public int Result { get; set; }
        public DateTime DateTime { get; set; }

        public virtual Team AwayTeam { get; set; }
        public virtual Team HomeTeam { get; set; }
        public virtual ICollection<PlayerStatistic> PlayerStatistics { get; set; }
        public virtual ICollection<Bet> Bets { get; set; }
    }
}