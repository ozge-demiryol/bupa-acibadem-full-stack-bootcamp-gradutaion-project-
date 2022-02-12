using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Entity.Dto
{
    public class DtoCity : DtoBase
    {
        public DtoCity()
        {

        }
        public int CityId { get; set; }
        public string CityName { get; set; }
    }
}
