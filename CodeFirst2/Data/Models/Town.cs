using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst2.Data.Models
{
    public class Town
    {
        public Town()
        {
            Teams = new HashSet<Team>();
        }

        [Key]
        public int TownId { get; set; }

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
    }
}