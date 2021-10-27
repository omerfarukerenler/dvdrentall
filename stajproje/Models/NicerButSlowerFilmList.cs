using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace stajproje.Models
{
    [Keyless]
    [Table("nicer_but_slower_film_list")]
    public partial class NicerButSlowerFilmList
    {
        [Column("fid")]
        public int? Fid { get; set; }
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("category")]
        [StringLength(25)]
        public string Category { get; set; }
        [Column("price")]
        public decimal? Price { get; set; }
        [Column("length")]
        public short? Length { get; set; }
        [Column("actors")]
        public string Actors { get; set; }
    }
}
