using InsuranceSystem.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Entity.Dto
{
    public class DtoCustomer : DtoBase
    {
        public DtoCustomer()
        {

        }

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdentityNo { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }
        public int RegionId { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
    }
}
