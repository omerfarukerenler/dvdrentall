using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace stajproje.Models
{
    [Table("inventory")]
    [Index(nameof(StoreId), nameof(FilmId), Name = "idx_store_id_film_id")]
    public partial class Inventory
    {
        [Key]
        [Column("inventory_id")]
        public int InventoryId { get; set; }
        [Column("film_id")]
        public short FilmId { get; set; }
        [Column("store_id")]
        public short StoreId { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
