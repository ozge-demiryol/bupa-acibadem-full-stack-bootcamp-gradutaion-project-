using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Entity.Dto
{
    public class DtoOrdersCustomer:DtoBase
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
