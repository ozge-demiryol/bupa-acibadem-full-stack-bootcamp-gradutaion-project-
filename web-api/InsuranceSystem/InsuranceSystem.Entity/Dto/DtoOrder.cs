using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Entity.Dto
{
    public class DtoOrder : DtoBase
    {
        public DtoOrder()
        {

        }

        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int PolicyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int PaymentId { get; set; }
    }
}
