using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace stajproje.Models
{
    [Table("film_category")]
    public partial class FilmCategory
    {
        [Key]
        [Column("film_id")]
        public short FilmId { get; set; }
        [Key]
        [Column("category_id")]
        public short CategoryId { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
