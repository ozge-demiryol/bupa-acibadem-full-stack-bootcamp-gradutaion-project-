using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Entity.Dto
{
    public class DtoOrderStatus : DtoBase
    {
        public DtoOrderStatus()
        {

        }

        public int StatusId { get; set; }
        public string Title { get; set; }
    }
}
