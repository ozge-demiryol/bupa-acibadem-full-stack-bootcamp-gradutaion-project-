using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Entity.Dto
{
    public class DtoRegion : DtoBase
    {
        public DtoRegion()
        {

        }

        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public int CityId { get; set; }
    }
}
