using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IProductService
    {
        // hepsini getirir
        IDataResult<List<Product>> GetAll();

        IResult Add(Product product);

        IDataResult<Product> GetById(int id);


        // katagori ıd sine göre getirir.
        IDataResult<List<Product>> GetAllByCategoryId(int id);

        // su fıyatlar arasındaki ürünnleri getir.
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
    }
}
