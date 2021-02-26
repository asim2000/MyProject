using Core.Data;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailsDTO> GetProductDetails();
    }
}
