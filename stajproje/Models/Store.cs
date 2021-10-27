using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace stajproje.Models
{
    [Table("store")]
    [Index(nameof(ManagerStaffId), Name = "idx_unq_manager_staff_id", IsUnique = true)]
    public partial class Store
    {
        [Key]
        [Column("store_id")]
        public int StoreId { get; set; }
        [Column("manager_staff_id")]
        public short ManagerStaffId { get; set; }
        [Column("address_id")]
        public short AddressId { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }
    }
}
