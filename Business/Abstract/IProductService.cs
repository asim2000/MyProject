using Core.Utilities.Results.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetById(int id);
        IDataResult<List<Product>> GetByCategoryId(int categoryId);
        IDataResult<List<ProductDetailsDTO>> GetProductDetails();
        IResult Update(Product product);
        IResult Delete(Product product);
        IResult Add(Product product);

    }
}
