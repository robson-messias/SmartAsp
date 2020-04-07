using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SmartAsp.Models.Base;
using System.Collections.Generic;

namespace SmartAsp.Models
{
    public class Brand : IEntity
    {
        [StringLength(150, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
