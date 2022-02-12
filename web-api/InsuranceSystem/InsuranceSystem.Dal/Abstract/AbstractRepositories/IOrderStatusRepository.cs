using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Dal.Abstract.AbstractRepositories
{
    public interface IOrderStatusRepository
    {
        IQueryable OrderStatusReport();
     }
}
