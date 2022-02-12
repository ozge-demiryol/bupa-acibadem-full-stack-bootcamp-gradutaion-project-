using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace InsuranceSystem.Entity.Models
{
    public partial class OrdersCustomer : EntityBase
    {
        public string IdentityNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string PaymentType { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
