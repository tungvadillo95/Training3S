using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DDDExample.Infrastructure.Entities
{
    [Table("Orders")]
    public class Order : BaseEntity
    {
        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
