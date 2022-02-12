using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InsuranceSystem.Entity.Models
{
    public partial class Order:EntityBase
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required(ErrorMessage ="Please choose a policy")]
        public int PolicyId { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [Required(ErrorMessage = "Please choose a payment type")]
        public int PaymentId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual PaymentType Payment { get; set; }
        public virtual Policy Policy { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
