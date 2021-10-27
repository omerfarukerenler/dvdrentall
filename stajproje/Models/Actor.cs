using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace stajproje.Models
{
    [Table("actor")]
    [Index(nameof(LastName), Name = "idx_actor_last_name")]
    public partial class Actor
    {
        [Key]
        [Column("actor_id")]
        public int ActorId { get; set; }
        [Required]
        [Column("first_name")]
        [StringLength(45)]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name")]
        [StringLength(45)]
        public string LastName { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
