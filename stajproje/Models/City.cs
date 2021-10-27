using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace stajproje.Models
{
    [Table("city")]
    [Index(nameof(CountryId), Name = "idx_fk_country_id")]
    public partial class City
    {
        [Key]
        [Column("city_id")]
        public int CityId { get; set; }
        [Required]
        [Column("city")]
        [StringLength(50)]
        public string City1 { get; set; }
        [Column("country_id")]
        public short CountryId { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
