using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    // IEntity kullanmdık cünkü bu bir veritabanı tablosu değil bu bırkaç veritabanı tablosunun joın halı(tek başına bır tablo değil belki birkaç tablonun birkaç sutununa denk gelir)
    public class ProductDetailDto:IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public short UnitsInStock { get; set; }
    }
}
