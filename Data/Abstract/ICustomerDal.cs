using Core.Data;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
