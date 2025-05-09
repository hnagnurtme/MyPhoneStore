using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneHub.Models
{
    public class Product : Entity
    {
        public Product()
        {
            Bookings = new HashSet<Booking>();
        }

        [Required]
        public string Model { get; set; }

        [Required]
        public string Brand { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public string ImageUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        public bool IsAvailable { get; set; } = true;

        // Navigation property
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
