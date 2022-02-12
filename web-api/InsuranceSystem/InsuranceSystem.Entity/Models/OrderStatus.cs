using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InsuranceSystem.Entity.Models
{
    public partial class OrderStatus : EntityBase
    {
        public OrderStatus()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int StatusId { get; set; }
        public string Title { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
