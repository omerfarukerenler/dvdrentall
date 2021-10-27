using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace stajproje.Models
{
    [Keyless]
    [Table("actor_info")]
    public partial class ActorInfo
    {
        [Column("actor_id")]
        public int? ActorId { get; set; }
        [Column("first_name")]
        [StringLength(45)]
        public string FirstName { get; set; }
        [Column("last_name")]
        [StringLength(45)]
        public string LastName { get; set; }
        [Column("film_info")]
        public string FilmInfo { get; set; }
    }
}
