using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace stajproje.Models
{
    [Keyless]
    [Table("customer_list")]
    public partial class CustomerList
    {
        [Column("id")]
        public int? Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("address")]
        [StringLength(50)]
        public string Address { get; set; }
        [Column("zip code")]
        [StringLength(10)]
        public string ZipCode { get; set; }
        [Column("phone")]
        [StringLength(20)]
        public string Phone { get; set; }
        [Column("city")]
        [StringLength(50)]
        public string City { get; set; }
        [Column("country")]
        [StringLength(50)]
        public string Country { get; set; }
        [Column("notes")]
        public string Notes { get; set; }
        [Column("sid")]
        public short? Sid { get; set; }
    }
}
