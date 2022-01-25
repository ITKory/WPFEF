using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WPFL.lib
{
    [Table("tab_games")]
    public class Game
    {
        [Column("id")]


        public int Id { get; set; }

        [Column("name")]
        [Required]
        public string Name { get; set; }

        [Column("publisher")]
        [Required]
        public string Publisher { get; set; }
        [Column("style")]
        [Required]
        public string Style { get; set; }
        [Column("publis_date")]
        [Required]
        public DateTime publiSDate { get; set; }

        [Column("is_delete")]
        [Required]
        [DefaultValue(false)]
        public bool IsDelete { get; set; }
    }
}
