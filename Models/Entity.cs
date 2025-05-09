using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhoneHub.Models
{
    public class Entity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }        public DateTime CreatedAt { get; set; } = new DateTime(2025, 5, 9);
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
