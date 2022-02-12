using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace InsuranceSystem.Entity.Models
{
    public partial class OrderDetail : EntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int DetailId { get; set; }
        public int CustomerId { get; set; }
        public int StatusId { get; set; }
        public int PaymentId { get; set; }
        public int CardId { get; set; }
        public int OrderId { get; set; }

        public virtual CreditCard Card { get; set; }
        public virtual Order Order { get; set; }
        public virtual PaymentType Payment { get; set; }
        public virtual OrderStatus Status { get; set; }
    }
}
