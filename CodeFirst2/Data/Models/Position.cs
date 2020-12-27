using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst2.Data.Models
{
    public class Position
    {
        public Position()
        {
            Players = new HashSet<Player>();
        }

        [Key]
        public int PositionId { get; set; }

        [MaxLength(32)]
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}