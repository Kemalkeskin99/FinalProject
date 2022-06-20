using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    //eğer data access de birden fazla secenegimiz(ınmemory,entityFramework,hibernet vs..) olduğu için ve bunların karışmaması için
    //concrete dosyasının içine alt dosyalar actık bu seçenekler için.

    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;//global değişken methotların dışında ama classın içinde

        public InMemoryProductDal()
        {
            _products = new List<Product> {
                 new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                 new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                 new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                 new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                 new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitsInStock=1}
                 };   
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
           // Product productTodelete = null;
          //  foreach (var p in _products)
           // {                                                 //eğer linq(lenguage ıntegrated query //dile gömülü sorgu) bilmeseydik silme işlemini boyle yapçaktık.işlemler.
                                                             // tek tek ürünleri tek tek dolaş(foreach kısmı)sonra benım verdiğim ıd ile ürünün ıd tutunca ürünü sil
              //  if(p.ProductId == product.ProductId)
              //  {
                  //  productTodelete = p;
              //  }
                
          //  }
          //  _products.Remove(productTodelete);

            Product productToDelete=_products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDelete);  
            
            // _products.SingleOrDefault foreach kısmına denk gelir.ürünleri tek tek dolaş der    
            //p=>  p takma adını ver
            //  => buna lambda denir 
            // bundan sonra bu işlemlerde (silme, güncelleme)hep linq kullancaz

        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            //bütün ürünleri listeledğimiz için return parametresini kullanıyoruz çünkü productın tümünü döndürüyoruz
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId==categoryId).ToList(); 
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            // gönderdiğim ürün id'sine sahip olan listedeki ürünü bul 
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName=product.ProductName;  
            productToUpdate.CategoryId=product.CategoryId;
            productToUpdate.UnitPrice=product.UnitPrice;  
            productToUpdate.UnitsInStock=product.UnitsInStock; 
            
            
        }
    }
}
