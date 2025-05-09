using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneHub.Models
{
    public class User : Entity
    {
        public User()
        {
            Bookings = new HashSet<Booking>();
        }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }
        
        public DateTime? LastLoginDate { get; set; }
        public bool IsActive { get; set; } = true;
        
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
