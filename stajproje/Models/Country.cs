using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace stajproje.Models
{
    [Table("country")]
    public partial class Country
    {
        [Key]
        [Column("country_id")]
        public int CountryId { get; set; }
        [Required]
        [Column("country")]
        [StringLength(50)]
        public string Country1 { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
