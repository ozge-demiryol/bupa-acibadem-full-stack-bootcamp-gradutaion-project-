using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace InsuranceSystem.Entity.Models
{
    public partial class CreditCard : EntityBase
    {
        public CreditCard()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int CardId { get; set; }
        public string CardNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime ExpDate { get; set; }
        public string Cvv { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
