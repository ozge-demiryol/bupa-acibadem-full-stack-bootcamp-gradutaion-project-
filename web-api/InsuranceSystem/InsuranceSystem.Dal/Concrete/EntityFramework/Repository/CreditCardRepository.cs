﻿using InsuranceSystem.Dal.Abstract.AbstractRepositories;
using InsuranceSystem.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Dal.Concrete.EntityFramework.Repository
{
    public class CreditCardRepository : GenericRepository<CreditCard>, ICreditCardRepository
    {
        public CreditCardRepository(DbContext context) : base(context)
        {

        }
        public IQueryable CreditCardReport()
        {
            return dbset.AsQueryable();
        }
    }
}
