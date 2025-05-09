using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace PhoneHub.Models
{
    public class Booking : Entity
    {
        [Required]
        public DateTime BookingDate { get; set; } = DateTime.Now;

        [Required]
        public DateTime DeliveryDate { get; set; }


        public string Status { get; set; } = "Pending";
         // Pending, Confirmed, Delivered, Cancelled
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        public string ShippingAddress { get; set; }

        public string Notes { get; set; }

        public int UserId { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
