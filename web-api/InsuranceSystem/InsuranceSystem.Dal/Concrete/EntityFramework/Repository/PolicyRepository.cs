using InsuranceSystem.Dal.Abstract.AbstractRepositories;
using InsuranceSystem.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Dal.Concrete.EntityFramework.Repository
{
    public class PolicyRepository : GenericRepository<Policy>, IPolicyRepository
    {
        public PolicyRepository(DbContext context) : base(context)
        {

        }

        public IQueryable PolicyReport()
        {
            return dbset.AsQueryable();
        }
    }
}
