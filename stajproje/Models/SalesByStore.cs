using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace stajproje.Models
{
    [Keyless]
    [Table("sales_by_store")]
    public partial class SalesByStore
    {
        [Column("store")]
        public string Store { get; set; }
        [Column("manager")]
        public string Manager { get; set; }
        [Column("total_sales")]
        public decimal? TotalSales { get; set; }
    }
}
