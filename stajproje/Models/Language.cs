using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace stajproje.Models
{
    [Table("language")]
    public partial class Language
    {
        [Key]
        [Column("language_id")]
        public int LanguageId { get; set; }
        [Required]
        [Column("name")]
        [StringLength(20)]
        public string Name { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
