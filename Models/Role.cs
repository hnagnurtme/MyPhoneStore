using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;

namespace PhoneHub.Models
{
    public class Role : Entity
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        [Required]
        public string Code { get; set; }

       
        public virtual ICollection<User> Users { get; set; }
    }
}
