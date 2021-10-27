using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace stajproje.Models
{
    [Table("customer")]
    [Index(nameof(AddressId), Name = "idx_fk_address_id")]
    [Index(nameof(StoreId), Name = "idx_fk_store_id")]
    [Index(nameof(LastName), Name = "idx_last_name")]
    public partial class Customer
    {
        [Key]
        [Column("customer_id")]
        public int CustomerId { get; set; }
        [Column("store_id")]
        public short StoreId { get; set; }
        [Required]
        [Column("first_name")]
        [StringLength(45)]
        public string FirstName { get; set; }
        [Required]
        [Column("last_name")]
        [StringLength(45)]
        public string LastName { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string Email { get; set; }
        [Column("address_id")]
        public short AddressId { get; set; }
        [Required]
        [Column("activebool")]
        public bool? Activebool { get; set; }
        [Column("create_date", TypeName = "date")]
        public DateTime CreateDate { get; set; }
        [Column("last_update")]
        public DateTime? LastUpdate { get; set; }
        [Column("active")]
        public int? Active { get; set; }
    }
}
