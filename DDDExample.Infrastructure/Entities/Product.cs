using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DDDExample.Infrastructure.Entities
{
    [Table("Products")]
    public class Product : BaseEntity
    {
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }
    }
}
