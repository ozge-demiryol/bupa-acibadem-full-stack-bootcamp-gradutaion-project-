using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Entity.Dto
{
    public class DtoPaymentType : DtoBase
    {
        public DtoPaymentType()
        {

        }

        public int PaymentId { get; set; }
        public string Title { get; set; }
    }
}
