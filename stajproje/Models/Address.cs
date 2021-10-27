﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace stajproje.Models
{
    [Table("address")]
    [Index(nameof(CityId), Name = "idx_fk_city_id")]
    public partial class Address
    {
        [Key]
        [Column("address_id")]
        public int AddressId { get; set; }
        [Required]
        [Column("address")]
        [StringLength(50)]
        public string Address1 { get; set; }
        [Required]
        [Column("district")]
        [StringLength(20)]
        public string District { get; set; }
        [Column("city_id")]
        public short CityId { get; set; }
        [Column("postal_code")]
        [StringLength(10)]
        public string PostalCode { get; set; }
        [Required]
        [Column("phone")]
        [StringLength(20)]
        public string Phone { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
