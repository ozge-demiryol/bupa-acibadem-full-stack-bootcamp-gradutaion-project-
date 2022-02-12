using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Entity.Dto
{
    public class DtoPolicy : DtoBase
    {
        public DtoPolicy()
        {

        }

        public int PolicyId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
