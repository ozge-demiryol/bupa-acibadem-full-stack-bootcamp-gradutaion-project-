using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Entity.Dto
{
    public class DtoOrderDetail : DtoBase
    {
        public DtoOrderDetail()
        {

        }

        public int DetailId { get; set; }
        public int CustomerId { get; set; }
        public int StatusId { get; set; }
        public int PaymentId { get; set; }
        public int CardId { get; set; }
        public int OrderId { get; set; }
    }
}
