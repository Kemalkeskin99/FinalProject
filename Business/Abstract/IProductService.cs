using Entities.Concrete;
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
        List<Product> GetAll();

        // katagori ıd sine göre getirir.
        List<Product> GetAllByCategoryId(int id);

        // su fıyatlar arasındaki ürünnleri getir.
        List<Product> GetByUnitPrice(decimal min, decimal max);
    }
}
