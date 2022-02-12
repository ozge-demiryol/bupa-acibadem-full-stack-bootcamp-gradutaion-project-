using InsuranceSystem.Dal.Abstract.AbstractRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Dal.Concrete.EntityFramework.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IQueryable OrderDetailReport()
        {
            throw new NotImplementedException();
        }
    }
}
