using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst2.Data.Models
{
    public class Team
    {
        public Team()
        {
            HomeGames = new HashSet<Game>();
            AwayGames = new HashSet<Game>();
            Players = new HashSet<Player>();
        }

        [Key]
        public int TeamId { get; set; }

        public int Budget { get; set; }
        public string Initials { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string LogoUrl { get; set; }

        [MaxLength(128)]
        public string Name { get; set; }

        [ForeignKey(nameof(PrimaryKitColor))]
        public int PrimaryKitColorId { get; set; }

        [ForeignKey(nameof(SecondaryKitColor))]
        public int SecondaryKitColorId { get; set; }

        [ForeignKey(nameof(Town))]
        public int TownId { get; set; }

        public virtual Color PrimaryKitColor { get; set; }
        public virtual Color SecondaryKitColor { get; set; }
        public virtual Town Town { get; set; }
        public virtual ICollection<Game> HomeGames { get; set; }
        public virtual ICollection<Game> AwayGames { get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}