using InsuranceSystem.Dal.Abstract.AbstractRepositories;
using InsuranceSystem.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace InsuranceSystem.Dal.Concrete.EntityFramework.Repository
{
    public class CityRepository : GenericRepository<City>, ICityRepository
    {
        public CityRepository(DbContext context) : base(context)
        {

        }

        public IQueryable CityReport()
        {
            return dbset.AsQueryable();
        }
    }
}
