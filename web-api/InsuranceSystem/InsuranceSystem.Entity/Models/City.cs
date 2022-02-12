using InsuranceSystem.Entity.Base;
using System.Collections.Generic;

#nullable disable

namespace InsuranceSystem.Entity.Models
{
    public partial class City : EntityBase
    {
        public City()
        {
            Customers = new HashSet<Customer>();
            Regions = new HashSet<Region>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
    }
}
