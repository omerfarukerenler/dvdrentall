using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace stajproje.Models
{
    [Table("rental")]
    [Index(nameof(InventoryId), Name = "idx_fk_inventory_id")]
    [Index(nameof(RentalDate), nameof(InventoryId), nameof(CustomerId), Name = "idx_unq_rental_rental_date_inventory_id_customer_id", IsUnique = true)]
    public partial class Rental
    {
        public Rental()
        {
            Payments = new HashSet<Payment>();
        }

        [Key]
        [Column("rental_id")]
        public int RentalId { get; set; }
        [Column("rental_date")]
        public DateTime RentalDate { get; set; }
        [Column("inventory_id")]
        public int InventoryId { get; set; }
        [Column("customer_id")]
        public short CustomerId { get; set; }
        [Column("return_date")]
        public DateTime? ReturnDate { get; set; }
        [Column("staff_id")]
        public short StaffId { get; set; }
        [Column("last_update")]
        public DateTime LastUpdate { get; set; }

        [InverseProperty(nameof(Payment.Rental))]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
