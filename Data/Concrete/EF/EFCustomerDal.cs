﻿using Core.Data.EntityFramework;
using Data.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Concrete.EF
{
    public class EFCustomerDal: EFEntityRepositoryBase<Customer, NorthwindContext>, ICustomerDal
    {
    }
}
