using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace stajproje.Models
{
    [Table("payment")]
    [Index(nameof(CustomerId), Name = "idx_fk_customer_id")]
    [Index(nameof(RentalId), Name = "idx_fk_rental_id")]
    [Index(nameof(StaffId), Name = "idx_fk_staff_id")]
    public partial class Payment
    {
        [Key]
        [Column("payment_id")]
        public int PaymentId { get; set; }
        [Column("customer_id")]
        public short CustomerId { get; set; }
        [Column("staff_id")]
        public short StaffId { get; set; }
        [Column("rental_id")]
        public int RentalId { get; set; }
        [Column("amount")]
        public decimal Amount { get; set; }
        [Column("payment_date")]
        public DateTime PaymentDate { get; set; }
        [Column("start_date")]
        public DateTime? StartDate { get; set; }
        [Column("end_date")]
        public DateTime? EndDate { get; set; }

        [ForeignKey(nameof(RentalId))]
        [InverseProperty("Payments")]
        public virtual Rental Rental { get; set; }
    }
}
